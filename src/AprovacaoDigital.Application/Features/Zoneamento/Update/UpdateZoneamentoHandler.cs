using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Zoneamento.Update;
public sealed record UpdateZoneamentoRequest : IRequest<int>
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public decimal? Taxa { get; set; }

    public int? Version { get; set; }

}



public sealed class UpdateZoneamentoHandler : IRequestHandler<UpdateZoneamentoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IZoneamentoRepository _repository;
    private readonly IMapper _mapper;
    public UpdateZoneamentoHandler(IUnitOfWork unitOfWork, IZoneamentoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateZoneamentoRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Zoneamentoid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Zoneamento>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Zoneamentoid;
    }


}
