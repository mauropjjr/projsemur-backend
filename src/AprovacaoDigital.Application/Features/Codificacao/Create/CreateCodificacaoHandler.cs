using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Codificacao.Create;
public sealed record CreateCodificacaoRequest : IRequest<int>
{
    public int Codificacaoid { get; set; }

    public string? Nome { get; set; }

    public decimal? Fatoratual { get; set; }

    public int? Pontobase { get; set; }

    public int? Pontoanalise1 { get; set; }

    public int? Pontoanalise2 { get; set; }

    public int? Pontoanalise3 { get; set; }

    public int? Pontoanalise4 { get; set; }

    public int? Pontoanalise5 { get; set; }

    public int? Especial { get; set; }



}



public sealed class CreateCodificacaoHandler : IRequestHandler<CreateCodificacaoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICodificacaoRepository _repository;
    private readonly IMapper _mapper;
    public CreateCodificacaoHandler(IUnitOfWork unitOfWork, ICodificacaoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateCodificacaoRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.Codificacao>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Codificacaoid;
    }


}
