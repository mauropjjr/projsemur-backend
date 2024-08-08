using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class ResiduosEstadofisico : BaseEntity
{
    public int Estadofisicoid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public string? Nome { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
