using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Domain.Enums;
using AutoMapper;
using MediatR;
using System;
using System.Threading;

namespace AprovacaoDigital.Application.Features.AlterarStatusAlvara;
public sealed record AlterarStatusAlvaraRequest : IRequest
{
    public int ProjetoId { get; set; }
    public int StatusId { get; set; }
    public RequestTipoProjetoEnum Tipo { get; set; }  //alterarStatusEAlvara, negarProjeto
    public string? ProcessoSubstitulo { get; set; }
    public string? Despacho { get; set; }



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

/* teste aprovar
  {
  "projetoId":77454,
  "statusId": 9,
  "processoSubstitulo": "AI0040/2024",
"tipo":0
}
*/
/*
 * teste negar
 despacho=123&id=76705&statusid=10
  {
  "projetoId":76705,
  "statusId": null,
  "despacho": "123",
"tipo":1
}
  {
  "projetoId":76807,
  "statusId": null,
  "despacho": "123",
"tipo":2
}
 */
public sealed class AlterarStatusAlvaraHandler : IRequestHandler<AlterarStatusAlvaraRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    private readonly IHistoricoServices _historicoServices;
    private readonly IDocumentoRepository _documentoRepository;
    public AlterarStatusAlvaraHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper, IHistoricoServices historicoServices, IDocumentoRepository documentoRepository)
    {
        _historicoServices = historicoServices;
        _unitOfWork = unitOfWork;
        _documentoRepository = documentoRepository;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task Handle(AlterarStatusAlvaraRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.FindId(x => x.Projetoid == request.ProjetoId, "AtividadeNavigation,Historicos,Remessas.Documentos.ArquivoNavigation,Remessas.Remessaexigencia.ExigenciaNavigation", cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.ProjetoId);
        }

        objeto.Status = request.StatusId;
        if (request.ProcessoSubstitulo != null)
        {
            objeto.Alvara = request.ProcessoSubstitulo;
        }

        //  _repository.Update(objeto);
        if (request.Tipo == RequestTipoProjetoEnum.AlterarStatusEAlvara)
            await alterarStatusEAlvara(objeto, cancellationToken);
        else if (request.Tipo == RequestTipoProjetoEnum.NegarProjeto)
            await negarProjeto(objeto, request.Despacho, cancellationToken);
        else if (request.Tipo == RequestTipoProjetoEnum.CancelarProjeto)
            await cancelarProjeto(objeto, request.Despacho, cancellationToken);
        else if (request.Tipo == RequestTipoProjetoEnum.alterarStatus)
            await alterarStatus(objeto,  cancellationToken);
        else
        {
            throw new Exception("Tipo incorreto");

        }

        await _unitOfWork.Save(cancellationToken);
    }
    private async Task alterarStatusEAlvara(Domain.Entities.Projeto projeto, CancellationToken cancellationToken)
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
    private async Task negarProjeto(Domain.Entities.Projeto projeto,string despacho, CancellationToken cancellationToken) {


        if (projeto.Status.Equals(10))
        {
            projeto.Alvara = null;
            projeto.Codseguranca = null;
            projeto.Datahomologacao = null;
 
            projeto.Despacho = despacho.ToUpper();
            var listaremessa = projeto.Remessas.Where(r => r.Status.Contains("RMF"));
            List<Documento> documentosRemover = new List<Documento>();
            if (listaremessa.Count() > 0)
            {
                listaremessa.ToList().ForEach(remessa => {
                    var documentos = remessa.Documentos;
                    if (documentos.Count() > 0)
                    {
                        documentos.ToList().ForEach(documento => {
                            documentosRemover.Add(documento);
                        });

                    }
                });
                if(documentosRemover.Count() > 0)
                {
                    _documentoRepository.ForceDeleteRange(documentosRemover);
                }
             
            }
            await _historicoServices.GerarTramiteProcesso(true, projeto, 10, cancellationToken);
        }
    }

    private async Task  cancelarProjeto(Domain.Entities.Projeto projeto, string ProcessoSubstitulo, CancellationToken cancellationToken)
    {
        var grupo = 43; //TODO: obter esse grupo de algum lugar
        if (grupo == 43) { // GRUPO VALTRUDES CHEFE
            projeto.Status = 16;
            if (!string.IsNullOrEmpty(ProcessoSubstitulo)) {
                projeto.Procsubstituto = ProcessoSubstitulo;
            }
            await _historicoServices.GerarTramiteProcesso(true, projeto, 18, cancellationToken);


        }

    }
    private async Task  alterarStatus(Domain.Entities.Projeto projeto, CancellationToken cancellationToken)
    {
//        historicoLogic.setTipoautor(3);
  //      historicoLogic.setAutorid(getUsuarioid());
        await _historicoServices.GerarTramiteProcesso(true, projeto, 13, cancellationToken);
    }


}
