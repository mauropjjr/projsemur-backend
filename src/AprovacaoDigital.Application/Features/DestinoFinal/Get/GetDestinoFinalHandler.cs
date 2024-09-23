using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.DestinoFinal.Get
{
    public sealed record GetResponse
    {
        public int Destinofinalid { get; set; }

        public string? Nome { get; set; }

    }

    public record GetRequest(int Id) : IRequest<GetResponse>;
    public sealed class GetDestinoFinalHandler : IRequestHandler<GetRequest, GetResponse>
    {
        private readonly IDestinoFinalRepository _repository;
        private readonly IMapper _mapper;

        public GetDestinoFinalHandler(IDestinoFinalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetResponse> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Destinofinalid == request.Id, cancellationToken);
            return _mapper.Map<GetResponse>(objeto);

        }

    }
}
