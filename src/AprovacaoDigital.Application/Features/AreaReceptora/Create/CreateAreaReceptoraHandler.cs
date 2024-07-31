using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Create;
public sealed record CreateAreaReceptoraRequest : IRequest<int>
{
    public int Tipo { get; set; }
    public string? Nome { get; set; }
    public string Numerolicenca { get; set; }
    public int Regiao { get; set; }

    public string? Endereco { get; set; }

    public int? Numero { get; set; }
    public string? Bairro { get; set; }
    public string? Telefone { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }

    public int? Ativo { get; set; }

}



public sealed class CreateAreaReceptoraHandler : IRequestHandler<CreateAreaReceptoraRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAreaReceptoraRepository _repository;
    private readonly IMapper _mapper;
    public CreateAreaReceptoraHandler(IUnitOfWork unitOfWork, IAreaReceptoraRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateAreaReceptoraRequest request, CancellationToken cancellationToken)
    {
        var objeto = _mapper.Map<Domain.Entities.AreaReceptora>(request);
        _repository.Create(objeto);
        await _unitOfWork.Save(cancellationToken);
        return objeto.Areareceptoraid;
    }


}
