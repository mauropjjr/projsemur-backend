using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.DestinoFinal.GetAll
{
    public sealed record GetAllDestinoFinalResponse
    {
        public int Destinofinalid { get; set; }

        public string? Nome { get; set; }
    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllDestinoFinalResponse>>
    {
        public string? Nome { get; set; }

    }

    public sealed class GetAllDestinoFinalHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllDestinoFinalResponse>>
    {
        private readonly IDestinoFinalRepository _repository;
        private readonly IMapper _mapper;

        public GetAllDestinoFinalHandler(IDestinoFinalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllDestinoFinalResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.DestinoFinal, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.DestinoFinal>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllDestinoFinalResponse>>(data);
            var paginate = new PaginatedList<GetAllDestinoFinalResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
