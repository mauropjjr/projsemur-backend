using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Zoneamento.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteZoneamentoHandler : IRequestHandler<DeleteRequest>
{
    private readonly IZoneamentoRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteZoneamentoHandler(IZoneamentoRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Zoneamentoid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
