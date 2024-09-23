using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.TipoArquivo.Get
{
    public sealed record GetResponse
    {
        public int TipoArquivoAgendaid { get; set; }

        public string? Nome { get; set; }

        public string? Ordem { get; set; }

    }

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetTipoArquivoHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly ITipoArquivoAgendaRepository _repository;
        private readonly IMapper _mapper;

        public GetTipoArquivoHandler(ITipoArquivoAgendaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Tipoarquivoid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
