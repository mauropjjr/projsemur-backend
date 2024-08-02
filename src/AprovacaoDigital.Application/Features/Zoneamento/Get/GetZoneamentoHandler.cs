using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Zoneamento.Get
{
    public sealed record GetResponse
    {
        public int Zoneamentoid { get; set; }

        public string? Nome { get; set; }

        public decimal? Taxa { get; set; }

        public int? Version { get; set; }
    }

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetZoneamentoHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IZoneamentoRepository _repository;
        private readonly IMapper _mapper;

        public GetZoneamentoHandler(IZoneamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.Get(x => x.Zoneamentoid == request.Id,  cancellationToken);          
            return _mapper.Map<GetResponse>(objeto);            

        }

    }
}
