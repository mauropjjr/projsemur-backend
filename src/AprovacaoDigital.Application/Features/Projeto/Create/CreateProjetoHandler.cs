using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Projeto.Create;


public sealed class CreateProjetoHandler : IRequestHandler<CreateProjetoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    public CreateProjetoHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateProjetoRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Projeto>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Projetoid;
    }


}
