using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Assunto.Create;
public sealed record CreateAssuntoRequest : IRequest<int>
{
    public string? Nome { get; set; }

}



public sealed class CreateAssuntoHandler : IRequestHandler<CreateAssuntoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAssuntoRepository _repository;
    private readonly IMapper _mapper;
    public CreateAssuntoHandler(IUnitOfWork unitOfWork, IAssuntoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateAssuntoRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Assunto1>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Assuntoid;
    }


}
