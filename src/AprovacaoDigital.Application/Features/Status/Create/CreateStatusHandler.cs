using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Status.Create;
public sealed record CreateStatusRequest : IRequest<int>
{
    public string? Descricao { get; set; }

}



public sealed class CreateStatusHandler : IRequestHandler<CreateStatusRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStatusRepository _repository;
    private readonly IMapper _mapper;
    public CreateStatusHandler(IUnitOfWork unitOfWork, IStatusRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateStatusRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Status1>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Statusid;
    }


}
