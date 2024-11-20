using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Codificacao.Update;
public sealed record UpdateCodificacaoRequest : IRequest<int>
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



public sealed class UpdateCodificacaoHandler : IRequestHandler<UpdateCodificacaoRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICodificacaoRepository _repository;
    private readonly IMapper _mapper;
    public UpdateCodificacaoHandler(IUnitOfWork unitOfWork, ICodificacaoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateCodificacaoRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Codificacaoid == request.Codificacaoid, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Codificacaoid);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Codificacao>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Codificacaoid;
    }


}
