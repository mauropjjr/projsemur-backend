using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Exigencia : BaseEntity
{
    public int Exigenciaid { get; set; }

    public string? Nome { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public string? Ordem { get; set; }

    public virtual ICollection<Remessaexigencia> Remessaexigencia { get; set; } = new List<Remessaexigencia>();
}
