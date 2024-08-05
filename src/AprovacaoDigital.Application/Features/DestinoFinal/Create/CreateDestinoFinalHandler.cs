using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Create;
public sealed record CreateDestinoFinalRequest : IRequest<int>
{
    public int DestinoFinalid { get; set; }

    public string? Nome { get; set; }


}



public sealed class CreateDestinoFinalHandler : IRequestHandler<CreateDestinoFinalRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDestinoFinalRepository _repository;
    private readonly IMapper _mapper;
    public CreateDestinoFinalHandler(IUnitOfWork unitOfWork, IDestinoFinalRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateDestinoFinalRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.DestinoFinal>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Destinofinalid;
    }


}
