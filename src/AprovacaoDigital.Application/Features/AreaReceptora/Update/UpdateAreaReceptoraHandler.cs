using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Update;
public sealed record UpdateAreaReceptoraRequest : IRequest<int>
{
    public int Id{ get; set; }


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



public sealed class UpdateAreaReceptoraHandler : IRequestHandler<UpdateAreaReceptoraRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAreaReceptoraRepository _repository;
    private readonly IMapper _mapper;
    public UpdateAreaReceptoraHandler(IUnitOfWork unitOfWork, IAreaReceptoraRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateAreaReceptoraRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Areareceptoraid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.AreaReceptora>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Areareceptoraid;
    }


}
