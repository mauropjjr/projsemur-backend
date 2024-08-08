using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Exigencia.GetAll
{
    public sealed record GetAllResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Ordem { get; set; }

        // public virtual ICollection<Remessaexigencia> Remessaexigencia { get; set; };

    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllResponse>>
    {
        public string? Nome { get; set; }
    }

    public sealed class GetAllExigenciaHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllResponse>>
    {
        private readonly IExigenciaRepository _repository;
        private readonly IMapper _mapper;

        public GetAllExigenciaHandler(IExigenciaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Exigencia, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Exigencia>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllResponse>>(data);
            var paginate = new PaginatedList<GetAllResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
