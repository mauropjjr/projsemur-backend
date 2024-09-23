using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Codificacao.Get
{
    public sealed record GetResponse
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

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetCodificacaoHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly ICodificacaoRepository _repository;
        private readonly IMapper _mapper;

        public GetCodificacaoHandler(ICodificacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Codificacaoid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
