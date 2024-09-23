using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Status.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteStatusHandler : IRequestHandler<DeleteRequest>
{
    private readonly IStatusRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteStatusHandler(IStatusRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Statusid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
