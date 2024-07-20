using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Exigencia.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteExigenciaHandler : IRequestHandler<DeleteRequest>
{
    private readonly IExigenciaRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteExigenciaHandler(IExigenciaRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Exigenciaid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
