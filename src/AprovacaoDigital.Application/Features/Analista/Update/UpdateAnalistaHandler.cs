using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Analista.Update;
public sealed record UpdateAnalistaRequest : IRequest<int>
{
    public int Id { get; set; }


    public string? Nome { get; set; }

    public int Flagativo { get; set; }

    public string Legenda { get; set; }

}



public sealed class UpdateAnalistaHandler : IRequestHandler<UpdateAnalistaRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAnalistaRepository _repository;
    private readonly IMapper _mapper;
    public UpdateAnalistaHandler(IUnitOfWork unitOfWork, IAnalistaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateAnalistaRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Analistaid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Analistum>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Analistaid;
    }


}
