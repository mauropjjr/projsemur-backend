using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Status.Get
{
    public sealed record GetStatusResponse
    {
        public int Id { get; set; }

        public string? Descricao { get; set; }

    }

    public record GetStatusRequest(int Id) : IRequest<GetStatusResponse>;
    public sealed class GetStatusHandler : IRequestHandler<GetStatusRequest, GetStatusResponse>
    {
        private readonly IStatusRepository _repository;
        private readonly IMapper _mapper;

        public GetStatusHandler(IStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetStatusResponse> Handle(GetStatusRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Statusid == request.Id, cancellationToken);
            return _mapper.Map<GetStatusResponse>(objeto);

        }

    }
}
