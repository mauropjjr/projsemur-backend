using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Documento1 : BaseEntity
{
    /// <summary>
    /// Código do documento
    /// </summary>
    public int Documentoid { get; set; }

    /// <summary>
    /// Situação do documento
    /// </summary>
    public int Situacao { get; set; }

    /// <summary>
    /// Remessa vinculado
    /// </summary>
    public int Remessa { get; set; }

    /// <summary>
    /// Arquivo vinculado
    /// </summary>
    public int Arquivo { get; set; }

    public virtual Arquivo1 ArquivoNavigation { get; set; } = null!;

    public virtual Remessa1 RemessaNavigation { get; set; } = null!;

    public virtual Situacao1 SituacaoNavigation { get; set; } = null!;
}
