using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Mensagem.Update;
public sealed record UpdateMensagemRequest : IRequest<int>
{
    public int Id { get; set; }

    public int ProjetoId { get; set; }

    public DateTime Datahora { get; set; }

    public string Usuario { get; set; } = null!; //Pegar

    public string Texto { get; set; } = null!;

    public int Lida { get; set; }
    public int Grupo { get; set; }


}



public sealed class UpdateMensagemHandler : IRequestHandler<UpdateMensagemRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMensagemRepository _repository;
    private readonly IMapper _mapper;
    public UpdateMensagemHandler(IUnitOfWork unitOfWork, IMensagemRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateMensagemRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.GetAsync(x => x.Mensagemid == request.Id, cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.Id);
        }

        var updateRequest = _mapper.Map<Domain.Entities.Mensagem>(request);
        _repository.Update(updateRequest);
        await _unitOfWork.Save(cancellationToken);
        return updateRequest.Mensagemid;
    }


}
