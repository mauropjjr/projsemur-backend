using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Mensagem.Create;
public sealed record CreateMensagemRequest : IRequest<int>
{

    public int ProjetoId { get; set; }

    public DateTime? Datahora { get; set; } = DateTime.Now;

    public string Usuario { get; set; } = null!; //Pegar usuario logado

    public string Texto { get; set; } = null!;

    public int Lida { get; set; } = 0;
    public int GrupoId { get; set; }


}



public sealed class CreateMensagemHandler : IRequestHandler<CreateMensagemRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMensagemRepository _repository;
    private readonly IMapper _mapper;
    public CreateMensagemHandler(IUnitOfWork unitOfWork, IMensagemRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateMensagemRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Mensagem>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Mensagemid;
    }


}
