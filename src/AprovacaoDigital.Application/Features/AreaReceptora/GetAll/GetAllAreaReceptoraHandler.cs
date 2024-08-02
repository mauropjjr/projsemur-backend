using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.AreaReceptora.GetAll
{
    public sealed record GetAllAreaReceptoraResponse
    {
        public int AreaReceptoraid { get; set; }


        public int Tipo { get; set; }
        public string? Nome { get; set; }
        public string Numerolicenca { get; set; }
        public int Regiao { get; set; }

        public string? Endereco { get; set; }

        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Telefone { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public int? Ativo { get; set; }
    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllAreaReceptoraResponse>>
    {
        public string? Nome { get; set; }
        public int? Ativo { get; set; }

    }

    public sealed class GetAllAreaReceptoraHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllAreaReceptoraResponse>>
    {
        private readonly IAreaReceptoraRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAreaReceptoraHandler(IAreaReceptoraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllAreaReceptoraResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.AreaReceptora, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }
            if (request.Ativo != null)
            {
                filter = x => x.Ativo == request.Ativo;
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.AreaReceptora>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllAreaReceptoraResponse>>(data);
            var paginate = new PaginatedList<GetAllAreaReceptoraResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}
