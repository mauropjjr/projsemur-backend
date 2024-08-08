using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Atividade.Update;
public sealed record UpdateAtividadeRequest : IRequest<int>
{
    public int Id { get; set; }

    public string? Nome { get; set; }

}



public sealed class UpdateAtividadeHandler : IRequestHandler<UpdateAtividadeRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAtividadeRepository _repository;
    private readonly IMapper _mapper;
    public UpdateAtividadeHandler(IUnitOfWork unitOfWork, IAtividadeRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateAtividadeRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Atividadeid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Atividade>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Atividadeid;
    }


}
