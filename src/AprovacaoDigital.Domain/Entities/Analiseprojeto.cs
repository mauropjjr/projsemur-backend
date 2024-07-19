using AprovacaoDigital.Domain.Common;



namespace AprovacaoDigital.Domain.Entities;

public class Analiseprojeto : BaseEntity
{
    public int Analiseprojetoid { get; set; }

    public int? Projeto { get; set; }

    public int? Analista { get; set; }

    public string? Datahora { get; set; }

    public int? Numeroanalise { get; set; }

    public int? Numeroanalisereal { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Version { get; set; }

    public int? Codificacao { get; set; }

    public virtual Analistum? AnalistaNavigation { get; set; }

    public virtual Codificacao? CodificacaoNavigation { get; set; }

    public virtual Projeto? ProjetoNavigation { get; set; }
}
