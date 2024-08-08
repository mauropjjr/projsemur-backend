using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Transportadoraresiduo : BaseEntity
{
    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Version { get; set; }

    public int? Residuo { get; set; }

    public int? Transportadora { get; set; }

    public int Transportadoraresiduoid { get; set; }

    public string? Licencaambiental { get; set; }

    public DateOnly? Validadelicenca { get; set; }

    public virtual Residuo1? ResiduoNavigation { get; set; }

    public virtual Transportadora? TransportadoraNavigation { get; set; }
}
