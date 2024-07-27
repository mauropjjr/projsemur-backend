using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.TipoArquivo.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteTipoArquivoHandler : IRequestHandler<DeleteRequest>
{
    private readonly ITipoArquivoAgendaRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteTipoArquivoHandler(ITipoArquivoAgendaRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Tipoarquivoid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
