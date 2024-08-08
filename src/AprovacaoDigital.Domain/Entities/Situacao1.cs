using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Situacao1 : BaseEntity
{
    /// <summary>
    /// Código da situação
    /// </summary>
    public int Situacaoid { get; set; }

    /// <summary>
    /// Descrição da situação
    /// </summary>
    public string Descricao { get; set; } = null!;

    public virtual ICollection<Documento1> Documento1s { get; set; } = new List<Documento1>();
}
