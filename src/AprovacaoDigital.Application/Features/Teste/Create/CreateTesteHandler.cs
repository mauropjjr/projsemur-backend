using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Teste.Create;
public sealed record CreateTesteRequest : IRequest<int>
{
    public string Descricao { get; set; }

}



public sealed class CreateTesteHandler : IRequestHandler<CreateTesteRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITesteRepository _repository;
    private readonly IMapper _mapper;
    public CreateTesteHandler(IUnitOfWork unitOfWork, ITesteRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateTesteRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Teste>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Id;
    }


}
