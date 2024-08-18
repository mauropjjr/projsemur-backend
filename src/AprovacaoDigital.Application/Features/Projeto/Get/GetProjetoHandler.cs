using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Projeto.Get;


    public record GetRequest(int Id) : IRequest<GetProjetoResponse>;
    public sealed class GetProjetoHandler : IRequestHandler<GetRequest, GetProjetoResponse>
    {
        private readonly IProjetoRepository _repository;
        private readonly IMapper _mapper;

        public GetProjetoHandler(IProjetoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetProjetoResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.FindId(x => x.Projetoid == request.Id, "AtividadeNavigation,AnalistaNavigation,CodificacaoNavigation,FiscalNavigation,NaturezaNavigation,ProfissionalNavigation,RegiaoNavigation,ZoneamentoNavigation", cancellationToken);
            return _mapper.Map<GetProjetoResponse>(objeto);

        }

    }

