using AprovacaoDigital.Domain.Common;

namespace AprovacaoDigital.Domain.Entities;

public class Analistum1 : BaseEntity
{
    /// <summary>
    /// Código do analista
    /// </summary>
    public int Analistaid { get; set; }

    /// <summary>
    /// Nome do analista
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// Código do analista no cadastro do mainframe, tem que estar correto para EXPORTAÇÃO DOS PROJ para o MAINFRAME
    /// </summary>
    public int Codmain { get; set; }

    public virtual ICollection<Projetoana> Projetoanas { get; set; } = new List<Projetoana>();

    public virtual ICollection<Remessa1> Remessa1s { get; set; } = new List<Remessa1>();
}
