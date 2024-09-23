using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Atividade.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteAtividadeHandler : IRequestHandler<DeleteRequest>
{
    private readonly IAtividadeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteAtividadeHandler(IAtividadeRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Atividadeid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
