using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Bemvindo : BaseEntity
{
    public int Bemvindoid { get; set; }

    public string? Conteudo { get; set; }

    public int Ativo { get; set; }

    public int Unidadeaud { get; set; }

    public int Grupoaud { get; set; }

    public int Usuarioaud { get; set; }

    public int Version { get; set; }

    public DateTime? Datahora { get; set; }
}
