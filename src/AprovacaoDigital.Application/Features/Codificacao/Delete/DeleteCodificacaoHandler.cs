using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Codificacao.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteCodificacaoHandler : IRequestHandler<DeleteRequest>
{
    private readonly ICodificacaoRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteCodificacaoHandler(ICodificacaoRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Codificacaoid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
