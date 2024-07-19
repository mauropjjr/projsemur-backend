using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Analistum : BaseEntity
{
    public int Analistaid { get; set; }

    public string? Nome { get; set; }

    public string? Legenda { get; set; }

    public int? Codigomainframe { get; set; }

    public int? Grupo { get; set; }

    public int? Atividade { get; set; }

    public int? Dataexclusao { get; set; }

    public int? Grupoaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public int? Usuario { get; set; }

    public int? Flagativo { get; set; }

    public virtual ICollection<Analiseprojeto> Analiseprojetos { get; set; } = new List<Analiseprojeto>();

    public virtual ICollection<Projeto> ProjetoAnalistaNavigations { get; set; } = new List<Projeto>();

    public virtual ICollection<Projeto> ProjetoFiscalNavigations { get; set; } = new List<Projeto>();

    public virtual ICollection<Remessa> Remessas { get; set; } = new List<Remessa>();
}
