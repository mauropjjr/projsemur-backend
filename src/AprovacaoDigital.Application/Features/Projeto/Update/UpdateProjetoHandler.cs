using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Projeto.Update;


public sealed class UpdateProjetoHandler : IRequestHandler<UpdateProjetoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    public UpdateProjetoHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateProjetoRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Projetoid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Projeto>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Projetoid;
    }


}
