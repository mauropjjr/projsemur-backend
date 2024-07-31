using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Update;
public sealed record UpdateTipoArquivoAgendaRequest : IRequest<int>
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public int? Version { get; set; }

    public string? Extension { get; set; }

    public string? Contenttype { get; set; }

    public int? Ativo { get; set; }


}



public sealed class UpdateTipoArquivoHandler : IRequestHandler<UpdateTipoArquivoAgendaRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITipoArquivoAgendaRepository _repository;
    private readonly IMapper _mapper;
    public UpdateTipoArquivoHandler(IUnitOfWork unitOfWork, ITipoArquivoAgendaRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateTipoArquivoAgendaRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.Get(x => x.Tipoarquivoid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.TipoArquivoAgenda>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Tipoarquivoid;
    }


}
