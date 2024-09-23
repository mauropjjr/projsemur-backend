using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.DestinoFinal.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteDestinoFinalHandler : IRequestHandler<DeleteRequest>
{
    private readonly IDestinoFinalRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteDestinoFinalHandler(IDestinoFinalRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Destinofinalid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
