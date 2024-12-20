﻿using AprovacaoDigital.Application.Repositories;
using MediatR;


namespace AprovacaoDigital.Application.Features.Analista.Delete;


public record DeleteRequest(int Id) : IRequest;

public sealed class DeleteAnalistaHandler : IRequestHandler<DeleteRequest>
{
    private readonly IAnalistaRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteAnalistaHandler(IAnalistaRepository repository, IUnitOfWork unitOfWork)
    {

        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(DeleteRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Analistaid == request.Id, cancellationToken);
        _repository.ForceDelete(objeto);
        await _unitOfWork.Save(cancellationToken);

    }
}
