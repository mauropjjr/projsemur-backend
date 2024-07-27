using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Create;
public sealed record CreateTipoArquivoRequest : IRequest<int>
{
    public string? Nome { get; set; }
    
    public int? Version { get; set; }

    public string? Extension { get; set; }

    public string? Contenttype { get; set; }

    public int? Ativo { get; set; }

}



public sealed class CreateTipoArquivoHandler : IRequestHandler<CreateTipoArquivoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITipoArquivoAgendaRepository _repository;
    private readonly IMapper _mapper;
    public CreateTipoArquivoHandler(IUnitOfWork unitOfWork, ITipoArquivoAgendaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateTipoArquivoRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.TipoArquivoAgenda>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Tipoarquivoid;
    }


}
