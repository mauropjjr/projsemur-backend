using AprovacaoDigital.Application.Common.DTOs;
using AprovacaoDigital.Application.Features.Projeto.Get;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Analista.Get
{
    public sealed record GetResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public int Flagativo { get; set; }

        public string Legenda { get; set; }
        public ICollection<GetProjetoResponse> ProjetoAnalistaNavigations { get; set; }
        public ICollection<GetRemessaRequest> Remessas { get; set; }

}

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetAnalistaHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IAnalistaRepository _repository;
        private readonly IMapper _mapper;

        public GetAnalistaHandler(IAnalistaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            /*
             *     public virtual ICollection<Analiseprojeto> Analiseprojetos { get; set; } = new List<Analiseprojeto>();

    public virtual ICollection<Projeto> ProjetoAnalistaNavigations { get; set; } = new List<Projeto>();

    public virtual ICollection<Projeto> ProjetoFiscalNavigations { get; set; } = new List<Projeto>();

    public virtual ICollection<Remessa> Remessas { get; set; } = new List<Remessa>();
            */
            var objeto = await _repository.FindId(x => x.Analistaid == request.Id, "ProjetoAnalistaNavigations,Remessas", cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
