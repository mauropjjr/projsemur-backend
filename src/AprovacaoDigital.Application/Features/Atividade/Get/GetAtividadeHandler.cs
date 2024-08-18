using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Atividade.Get
{
    public sealed record GetResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

    }

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetAtividadeHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IAtividadeRepository _repository;
        private readonly IMapper _mapper;

        public GetAtividadeHandler(IAtividadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.Get(x => x.Atividadeid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
