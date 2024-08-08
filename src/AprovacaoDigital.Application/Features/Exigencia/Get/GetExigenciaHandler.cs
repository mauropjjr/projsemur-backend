using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Exigencia.Get
{
    public sealed record GetResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Ordem { get; set; }

    }

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetExigenciaHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IExigenciaRepository _repository;
        private readonly IMapper _mapper;

        public GetExigenciaHandler(IExigenciaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.Get(x => x.Exigenciaid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
