using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Historico : BaseEntity
{
    public int Historicoid { get; set; }

    public int Projeto { get; set; }

    public DateTime Datahora { get; set; }

    public int Sequencia { get; set; }

    public string Despacho { get; set; } = null!;

    public string Autor { get; set; } = null!;

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    public int? Exportado { get; set; }

    public DateTime? Dataexportado { get; set; }

    public virtual Projeto ProjetoNavigation { get; set; } = null!;
}
