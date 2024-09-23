using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.AreaReceptora.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteAreaReceptoraHandler : IRequestHandler<DeleteRequest>
{
    private readonly IAreaReceptoraRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteAreaReceptoraHandler(IAreaReceptoraRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Areareceptoraid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
