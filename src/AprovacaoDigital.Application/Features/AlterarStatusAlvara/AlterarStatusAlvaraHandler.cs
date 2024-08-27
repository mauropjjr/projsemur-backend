using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AprovacaoDigital.Domain.Entities;
using AutoMapper;
using MediatR;
using System;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Update;
public sealed record AlterarStatusAlvaraRequest : IRequest
{
    public int ProjetoId { get; set; }
    public int StatusId { get; set; }
    public string? ProcessoSubstitulo { get; set; }


}

//TODO: olhar logica
//https://git.campogrande.ms.gov.br/financeiro/aprovacao-digital/projsemur/-/blob/master/src/main/java/model/facade/projsemur/ProjetoLogic.java
//https://git.campogrande.ms.gov.br/financeiro/aprovacao-digital/projsemur/-/blob/master/src/main/java/model/facade/projsemur/HistoricoLogic.java

public sealed class AlterarStatusAlvaraHandler : IRequestHandler<AlterarStatusAlvaraRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    public AlterarStatusAlvaraHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task Handle(AlterarStatusAlvaraRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _repository.FindId(x => x.Projetoid == request.ProjetoId, "Remessas.Documentos.ArquivoNavigation, Remessas.Remessaexigencia.ExigenciaNavigation", cancellationToken);
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.ProjetoId);
        }

       objeto.Status = request.StatusId;
        _repository.Update(objeto);
        await _unitOfWork.Save(cancellationToken);
    }
    private await Task cancelarProjeto(AlterarStatusAlvaraRequest request,Domain.Entities.Projeto projeto) 
    {

      //  if (getGrupoid() == 43) { // GRUPO VALTRUDES CHEFE
     //       proj.setStatus(16);
     //       if (getProcsubstituto() != null && !getProcsubstituto().equals("")) {
     //           proj.setProcsubstituto(getProcsubstituto());
            }
//proj = (Projeto) getDao().saveOrUpdate(proj);
        var historico = new Historico() { 
            Projeto = request.ProjetoId,
            tram
        };

historicoLogic.setProjetoid(proj.getProjetoid());
            historicoLogic.setTipotramite(18);
            historicoLogic.setTipoautor(3); // SISTEMA
            historicoLogic.setAutorid(getUsuarioid());
            String s = (String)historicoLogic.gerarTramiteProcesso();

String despacho = historicoLogic.criarDespacho(proj);
String despachoprop = historicoLogic.criarDespachoProprietario(proj);

        }
        
    }



}
