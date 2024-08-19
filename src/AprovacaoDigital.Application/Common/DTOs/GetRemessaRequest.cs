
namespace AprovacaoDigital.Application.Common.DTOs;

public class GetRemessaRequest
{

    public int Id { get; set; }
    public string? Titulo { get; set; }


    public DateTime? Data { get; set; }


    public string? Descricao { get; set; }


    public int Projeto { get; set; }

    public string? Remetente { get; set; }

    /// <summary>
    /// PROF - Remessa em construção pelo Profissional.
    /// CONF - Remessa Conferida pelo Ananalista/Supervisor
    /// FIN - Remessa finalizada pelo Profissional.
    /// RMF - Remessa Final
    /// </summary>
    public string? Status { get; set; }

    public int? Exigido { get; set; }

    public string? Despacho { get; set; }

    public string? Despachosemadur { get; set; }

    public DateTime? Datahoraexigencia { get; set; }

    public int? Analista { get; set; }

    public virtual GetAnalistaRequest? AnalistaNavigation { get; set; }

    public virtual ICollection<GetDocumentoRequest> Documentos { get; set; } = new List<GetDocumentoRequest>();

    //public virtual GetProjetoResponse ProjetoNavigation { get; set; } = null!;

    //public virtual ICollection<Remessaexigencia> Remessaexigencia { get; set; } = new List<Remessaexigencia>();
}
