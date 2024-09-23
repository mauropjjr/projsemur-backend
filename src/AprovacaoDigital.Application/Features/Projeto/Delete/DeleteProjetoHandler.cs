using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Projeto.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteProjetoHandler : IRequestHandler<DeleteRequest>
{
    private readonly IProjetoRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteProjetoHandler(IProjetoRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Projetoid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
