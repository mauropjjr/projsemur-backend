using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.AreaReceptora.Get
{
    public sealed record GetResponse
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

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetAreaReceptoraHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IAreaReceptoraRepository _repository;
        private readonly IMapper _mapper;

        public GetAreaReceptoraHandler(IAreaReceptoraRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.Get(x => x.Areareceptoraid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
