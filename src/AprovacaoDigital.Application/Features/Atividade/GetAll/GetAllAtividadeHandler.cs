using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Atividade.GetAll
{
    public sealed record GetAllAtividadeResponse
    {
        public int Atividadeid { get; set; }

        public string? Nome { get; set; }
    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllAtividadeResponse>>
    {
        public string? Nome { get; set; }

    }

    public sealed class GetAllAtividadeHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllAtividadeResponse>>
    {
        private readonly IAtividadeRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAtividadeHandler(IAtividadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllAtividadeResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Atividade, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Atividade>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllAtividadeResponse>>(data);
            var paginate = new PaginatedList<GetAllAtividadeResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
