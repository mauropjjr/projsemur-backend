using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Exigencia.Create;
public sealed record CreateExigenciaRequest : IRequest<int>
{
    public string? Nome { get; set; }
    public string? Ordem { get; set; }

}



public sealed class CreateExigenciaHandler : IRequestHandler<CreateExigenciaRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IExigenciaRepository _repository;
    private readonly IMapper _mapper;
    public CreateExigenciaHandler(IUnitOfWork unitOfWork, IExigenciaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateExigenciaRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Exigencia>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Exigenciaid;
    }


}
