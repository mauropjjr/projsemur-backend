using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Exigencia.Update;
public sealed record UpdateExigenciaRequest : IRequest<int>
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Ordem { get; set; }

}



public sealed class UpdateExigenciaHandler : IRequestHandler<UpdateExigenciaRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IExigenciaRepository _repository;
    private readonly IMapper _mapper;
    public UpdateExigenciaHandler(IUnitOfWork unitOfWork, IExigenciaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateExigenciaRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Exigenciaid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Exigencia>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Exigenciaid;
    }


}
