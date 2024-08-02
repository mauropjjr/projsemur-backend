using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Zoneamento.Create;
public sealed record CreateZoneamentoRequest : IRequest<int>
{
    public int Zoneamentoid { get; set; }

    public string? Nome { get; set; }

    public decimal? Taxa { get; set; }

    public int? Version { get; set; }


}



public sealed class CreateZoneamentoHandler : IRequestHandler<CreateZoneamentoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IZoneamentoRepository _repository;
    private readonly IMapper _mapper;
    public CreateZoneamentoHandler(IUnitOfWork unitOfWork, IZoneamentoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateZoneamentoRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Zoneamento>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Zoneamentoid;
    }


}
