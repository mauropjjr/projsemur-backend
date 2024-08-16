using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Codificacao.GetAll
{
    public sealed record GetAllCodificacaoResponse
    {
        public int Codificacaoid { get; set; }

        public string? Nome { get; set; }

        public decimal? Fatoratual { get; set; }

        public int? Pontobase { get; set; }

        public int? Pontoanalise1 { get; set; }

        public int? Pontoanalise2 { get; set; }

        public int? Pontoanalise3 { get; set; }

        public int? Pontoanalise4 { get; set; }

        public int? Pontoanalise5 { get; set; }

        public int? Especial { get; set; }

    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllCodificacaoResponse>>
    {
        public string? Nome { get; set; }
        public int? Ativo { get; set; }

    }

    public sealed class GetAllCodificacaoHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllCodificacaoResponse>>
    {
        private readonly ICodificacaoRepository _repository;
        private readonly IMapper _mapper;

        public GetAllCodificacaoHandler(ICodificacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllCodificacaoResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Codificacao, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Codificacao>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllCodificacaoResponse>>(data);
            var paginate = new PaginatedList<GetAllCodificacaoResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
