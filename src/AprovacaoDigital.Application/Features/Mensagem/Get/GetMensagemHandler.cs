using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Mensagem.Get
{
    public sealed record GetMensagemResponse
    {
        public int Id { get; set; }

        public int ProjetoId { get; set; }

        public DateTime Datahora { get; set; }

        public string Usuario { get; set; } = null!; //Pegar

        public string Texto { get; set; } = null!;

        public int Lida { get; set; }
        public int Grupo { get; set; }

    }

    public record GetMensagemRequest(int Id) : IRequest<GetMensagemResponse>;
    public sealed class GetMensagemHandler : IRequestHandler<GetMensagemRequest, GetMensagemResponse>
    {
        private readonly IMensagemRepository _repository;
        private readonly IMapper _mapper;

        public GetMensagemHandler(IMensagemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetMensagemResponse> Handle(GetMensagemRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Mensagemid == request.Id, cancellationToken);
            return _mapper.Map<GetMensagemResponse>(objeto);

        }

    }
}
