using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Update;
public sealed record AlterarStatusAlvaraRequest : IRequest
{
    public int ProjetoId { get; set; }
    public int StatusId { get; set; }


}



public sealed class AlterarStatusAlvaraHandler : IRequestHandler<AlterarStatusAlvaraRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    public AlterarStatusAlvaraHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task Handle(AlterarStatusAlvaraRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Projetoid == request.ProjetoId, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.ProjetoId);
        }

       objeto.Status = request.StatusId;
        _repository.Update(objeto);
        await _unitOfWork.Save(cancellationToken);
    }


}
