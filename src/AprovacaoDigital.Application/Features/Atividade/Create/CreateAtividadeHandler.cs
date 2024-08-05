using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Atividade.Create;
public sealed record CreateAtividadeRequest : IRequest<int>
{
    public int Atividadeid { get; set; }

    public string? Nome { get; set; }


}



public sealed class CreateAtividadeHandler : IRequestHandler<CreateAtividadeRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAtividadeRepository _repository;
    private readonly IMapper _mapper;
    public CreateAtividadeHandler(IUnitOfWork unitOfWork, IAtividadeRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateAtividadeRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Atividade>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Atividadeid;
    }


}
