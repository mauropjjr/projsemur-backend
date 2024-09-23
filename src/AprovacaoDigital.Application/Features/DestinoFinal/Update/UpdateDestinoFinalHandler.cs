using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Update;
public sealed record UpdateDestinoFinalRequest : IRequest<int>
{
    public int Id { get; set; }

    public string? Nome { get; set; }

}



public sealed class UpdateDestinoFinalHandler : IRequestHandler<UpdateDestinoFinalRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDestinoFinalRepository _repository;
    private readonly IMapper _mapper;
    public UpdateDestinoFinalHandler(IUnitOfWork unitOfWork, IDestinoFinalRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateDestinoFinalRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Destinofinalid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.DestinoFinal>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Destinofinalid;
    }


}
