using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Analista.GetAll
{
    public sealed record GetAllAnalistaResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? Legenda { get; set; }
        public int Flagativo { get; set; }
    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllAnalistaResponse>>
    {
        public string? Nome { get; set; }
        public string? Legenda { get; set; }
        public int Flagativo { get; set; }

    }

    public sealed class GetAllAnalistaHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllAnalistaResponse>>
    {
        private readonly IAnalistaRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAnalistaHandler(IAnalistaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllAnalistaResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Analistum, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = filter == null
                   ? x => x.Nome.Contains(request.Nome)
                   : filter.And(x => x.Nome.Contains(request.Nome));
            }
            if (!string.IsNullOrEmpty(request.Legenda))
            {
                filter = filter == null
                   ? x => x.Legenda.Contains(request.Legenda)
                   : filter.And(x => x.Legenda.Contains(request.Legenda));
            }
         
            if (request.Flagativo != null && request.Flagativo > 0)
            {
                filter = filter == null
                    ? (x => x.Flagativo == request.Flagativo)
                    : filter.And(x => x.Flagativo == request.Flagativo);
            }

         

            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Analistum>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllAnalistaResponse>>(data);
            var paginate = new PaginatedList<GetAllAnalistaResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
