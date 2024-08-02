using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Zoneamento.GetAll
{
    public sealed record GetAllZoneamentoResponse
    {
        public int Zoneamentoid { get; set; }

        public string? Nome { get; set; }

        public decimal? Taxa { get; set; }

        public int? Version { get; set; }
    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllZoneamentoResponse>>
    {
        public string? Nome { get; set; }
        public int? Ativo { get; set; }

    }

    public sealed class GetAllZoneamentoHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllZoneamentoResponse>>
    {
        private readonly IZoneamentoRepository _repository;
        private readonly IMapper _mapper;

        public GetAllZoneamentoHandler(IZoneamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllZoneamentoResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Zoneamento, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Zoneamento>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllZoneamentoResponse>>(data);
            var paginate = new PaginatedList<GetAllZoneamentoResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
