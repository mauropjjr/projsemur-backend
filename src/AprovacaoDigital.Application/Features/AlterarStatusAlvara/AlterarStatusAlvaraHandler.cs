using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.AlterarStatusAlvara;
public sealed record AlterarStatusAlvaraRequest : IRequest
{
    public int ProjetoId { get; set; }
    public int StatusId { get; set; }
    public string? ProcessoSubstitulo { get; set; }


}

//TODO: olhar logica
//https://git.campogrande.ms.gov.br/financeiro/aprovacao-digital/projsemur/-/blob/master/src/main/java/model/facade/projsemur/ProjetoLogic.java
//https://git.campogrande.ms.gov.br/financeiro/aprovacao-digital/projsemur/-/blob/master/src/main/java/model/facade/projsemur/HistoricoLogic.java

//Testes no botoes
//NEgar - Projeto.ProjetoLogic.negarProjeto - status=10
//Aprovar - Projeto.ProjetoLogic.alterarStatusEAlvara - status=9
//Cancelar/Substituir = Projeto.ProjetoLogic.cancelarProjeto - sttus=
//Indefirir =  Projeto.ProjetoLogic.alterarStatu - status=11

//grupo usuario
//43	91555

/* teste
  {
  "projetoId":77454,
  "statusId": 9,
  "processoSubstitulo": "AI0040/2024"
}
*/
public sealed class AlterarStatusAlvaraHandler : IRequestHandler<AlterarStatusAlvaraRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    private readonly IHistoricoServices _historicoServices;
    public AlterarStatusAlvaraHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper, IHistoricoServices historicoServices)
    {
        _historicoServices = historicoServices;
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task Handle(AlterarStatusAlvaraRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.FindId(x => x.Projetoid == request.ProjetoId, "Historicos,Remessas.Documentos.ArquivoNavigation,Remessas.Remessaexigencia.ExigenciaNavigation", cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.ProjetoId);
        }

        objeto.Status = request.StatusId;
        if (request.ProcessoSubstitulo != null)
        {
            objeto.Alvara = request.ProcessoSubstitulo;
        }

        _repository.Update(objeto);
        await alterarStatus(objeto, cancellationToken);
        await _unitOfWork.Save(cancellationToken);
    }
    private async Task alterarStatus(Domain.Entities.Projeto projeto, CancellationToken cancellationToken)
    {
        //Apenas grupo de valtrudes chefe pode fazer isso:

        //Como q eu pego o getProcsubstituto() ?
        //if (getProcsubstituto() != null && !getProcsubstituto().equals(""))
        //{
        //    proj.setProcsubstituto(getProcsubstituto());
        //}
        //historicoLogic.setTipoautor(3);
        //historicoLogic.setAutorid(getUsuarioid());
        int? tipoTramite = null;
        if (projeto.Status == 8)
        {
            tipoTramite = 8;
        }
        else if (projeto.Status == 9)
        {
            tipoTramite = 9;
            projeto.Datahomologacao = new DateTime();
        }
        else if (projeto.Status == 10)
        {
            tipoTramite = 10;
        }
        await _historicoServices.GerarTramiteProcesso(true, projeto, tipoTramite, cancellationToken);
    }


}
