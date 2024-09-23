using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Status.Update;
public sealed record UpdateStatusRequest : IRequest<int>
{
    public int Id { get; set; }
    public string? Descricao { get; set; }


}



public sealed class UpdateStatusHandler : IRequestHandler<UpdateStatusRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStatusRepository _repository;
    private readonly IMapper _mapper;
    public UpdateStatusHandler(IUnitOfWork unitOfWork, IStatusRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateStatusRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Statusid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Status1>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Statusid;
    }


}
