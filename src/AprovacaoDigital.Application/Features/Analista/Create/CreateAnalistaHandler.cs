using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Analista.Create;
public sealed record CreateAnalistaRequest : IRequest<int>
{

    public string? Nome { get; set; }
   
    public int Flagativo { get; set; }

    public string Legenda { get; set; }


}



public sealed class CreateAnalistaHandler : IRequestHandler<CreateAnalistaRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAnalistaRepository _repository;
    private readonly IMapper _mapper;
    public CreateAnalistaHandler(IUnitOfWork unitOfWork, IAnalistaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateAnalistaRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Analistum>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Analistaid;
    }


}
