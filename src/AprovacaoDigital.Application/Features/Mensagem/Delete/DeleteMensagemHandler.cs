using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Mensagem.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteMensagemHandler : IRequestHandler<DeleteRequest>
{
    private readonly IMensagemRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteMensagemHandler(IMensagemRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Mensagemid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
