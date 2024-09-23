using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;



namespace AprovacaoDigital.Application.Features.Assunto.Get
{
    public sealed record GetAssuntoResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

    }

    public record GetAssuntoRequest(int Id) : IRequest<GetAssuntoResponse>;
    public sealed class GetAssuntoHandler : IRequestHandler<GetAssuntoRequest, GetAssuntoResponse>
    {
        private readonly IAssuntoRepository _repository;
        private readonly IMapper _mapper;

        public GetAssuntoHandler(IAssuntoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<GetAssuntoResponse> Handle(GetAssuntoRequest request, CancellationToken cancellationToken)
        {
            var objeto = await _repository.GetAsync(x => x.Assuntoid == request.Id, cancellationToken);
            return _mapper.Map<GetAssuntoResponse>(objeto);

        }

    }
}
