using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Assunto.Update;
public sealed record UpdateAssuntoRequest : IRequest<int>
{
    public int Id { get; set; }
    public string? Nome { get; set; }


}



public sealed class UpdateAssuntoHandler : IRequestHandler<UpdateAssuntoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAssuntoRepository _repository;
    private readonly IMapper _mapper;
    public UpdateAssuntoHandler(IUnitOfWork unitOfWork, IAssuntoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateAssuntoRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Assuntoid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Assunto1>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Assuntoid;
    }


}
