using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Status.GetAll
{
    public sealed record GetAllStatusResponse
    {
        public int Id { get; set; }

        public string? Descricao { get; set; }



    }

    public sealed record GetAllStatusRequest : BaseRequest, IRequest<PaginatedList<GetAllStatusResponse>>
    {
        public string? Descricao { get; set; }
    }

    public sealed class GetAllStatusHandler : IRequestHandler<GetAllStatusRequest, PaginatedList<GetAllStatusResponse>>
    {
        private readonly IStatusRepository _repository;
        private readonly IMapper _mapper;

        public GetAllStatusHandler(IStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllStatusResponse>> Handle(GetAllStatusRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Status1, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Descricao))
            {
                filter = x => x.Descricao.Contains(request.Descricao);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Status1>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllStatusResponse>>(data);
            var paginate = new PaginatedList<GetAllStatusResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
