using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AprovacaoDigital.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Despachar.Update;


public sealed class UpdateDespacharHandler : IRequestHandler<UpdateDespacharRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IRemessaRepository _remessaRepository;
    private readonly IHistoricoServices _historicoServices;
    private readonly IMapper _mapper;
    private int grupoId;
    private int usuarioId;
    public UpdateDespacharHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IRemessaRepository remessaRepository, IHistoricoServices historicoServices, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _remessaRepository = remessaRepository;
        _historicoServices = historicoServices;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateDespacharRequest request, CancellationToken cancellationToken)
    {
        var objeto = await _remessaRepository.FindId(x => x.Remessaid == request.RemessaId, "ProjetoNavigation", cancellationToken);
        usuarioId = 91555;
        grupoId = 43;
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.RemessaId);
        }

        //var updateRequest = _mapper.Map<Domain.Entities.Projeto>(request);
        //_repository.Update(updateRequest);
        //await _unitOfWork.Save(cancellationToken);
        //return updateRequest.Projetoid;
        var retorno =  await CriarDespacho(objeto,request.Despacho, cancellationToken);
        return retorno.Remessaid;
    }
    private async Task<Remessa> CriarDespacho(Remessa remessa, string despacho, CancellationToken cancellationToken)
    {
        var tituloAutor = ObterTituloAutor();
        var semadur = IsSemadurGroup();
        var dataHoraAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        var autor = "CLARA KOHL DE ARAUJO"; //TODO: pegar da sessao
        //historicoLogic.setTipotramite(15);
        //historicoLogic.setTipoautor(3); // usuario
        //historicoLogic.setAutorid(getUsuarioid());
        //historicoLogic.setGrupoid(getGrupoid());

        var textoDespacho = $"{tituloAutor} ({dataHoraAtual})\nDESPACHO: {despacho}";

        if (semadur)
        {
            remessa.Despachosemadur = textoDespacho;
            remessa.Despacho = textoDespacho;
        }
        else
        {
            remessa.Despacho = textoDespacho;
        }
        _remessaRepository.Update(remessa);
        await _historicoServices.GerarHistoricoTramiteProcesso(remessa.ProjetoNavigation, remessa.Despacho, autor, 15, cancellationToken);
       

        await _unitOfWork.Save(cancellationToken);

        return remessa;
    }

    private string ObterTituloAutor()
    {
        return grupoId switch
        {
            46 => "DURP/SEMADUR DIRETOR DE DEPARTAMENTO",
            44 => usuarioId == 91457 ? "GAB/SEMADUR SECRETARIO ADJUNTO" : "GAB/SEMADUR SECRETARIO MUNICIPAL",
            45 => "GAB/SEMADUR SECRETARIO ADJUNTO",
            43 => "DFLU/SEMADUR CHEFE DE DIVISAO",
            //TODO: esse nome vai vir da tela, tem uma opçao de escolher qual é o usuario q vai o despacho
            //32 => $"DFLU/SEMADUR ANALISTA - {GetNome()}",
            //214 => $"DFUR/SEMADUR ANALISTA - {GetNome()}",
            //215 => $"DFUR/SEMADUR FISCAL - {GetNome()}",
            _ => string.Empty
        };
    }

    private bool IsSemadurGroup()
    {
        var semadurGroups = new[] { 46, 44, 45, 43 };
        return semadurGroups.Contains(grupoId);
    }

 



}
