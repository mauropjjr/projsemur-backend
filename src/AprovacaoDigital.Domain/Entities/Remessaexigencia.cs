using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Remessaexigencia : BaseEntity
{
    public int Remessaexigenciaid { get; set; }

    public int Remessa { get; set; }

    public int? Exigencia { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public string? Descricao { get; set; }

    public virtual Exigencia? ExigenciaNavigation { get; set; }

    public virtual Remessa RemessaNavigation { get; set; } = null!;
}
