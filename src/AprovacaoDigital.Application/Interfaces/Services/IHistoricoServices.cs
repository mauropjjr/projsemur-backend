using AprovacaoDigital.Domain.Entities;


namespace AprovacaoDigital.Application.Interfaces.Services;

public interface IHistoricoServices
{
    Task GerarTramiteProcesso(bool alteraStatus, Projeto projeto, int? tipoTramite, CancellationToken cancellationToken);
    //Task<string> CriarDespacho(Projeto projeto, int tipoTramite, CancellationToken cancellationToken);
    //string CriarDespachoProprietario(Projeto projeto, int tipoTramite);
    Task GerarHistoricoTramiteProcesso(Projeto projeto, String despacho, String autor, int? tipotramite, CancellationToken cancellationToken);
}
