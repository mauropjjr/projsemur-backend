using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class ResiduosCtrresiduo : BaseEntity
{
    public int Ctrresiduoid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public int? Ctr { get; set; }

    public int? Residuo { get; set; }

    public int? Qtde { get; set; }

    public int? Unidade { get; set; }

    public int? Qtdetrans { get; set; }

    public int? Unidadetrans { get; set; }

    public string? Codigobaixa { get; set; }

    public string? Numeromanifesto { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
