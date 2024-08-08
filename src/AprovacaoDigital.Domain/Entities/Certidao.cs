using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Certidao : BaseEntity
{
    public int Certidaoid { get; set; }

    public int? Numerocertidao { get; set; }

    public int Ano { get; set; }

    public int Tipoveiculodivulgacao { get; set; }

    public string Inscricaoimobiliaria { get; set; } = null!;

    public string Inscricaoeconomica { get; set; } = null!;

    public int? Cep { get; set; }

    public int? Regular { get; set; }

    public decimal? Dimensaox { get; set; }

    public decimal? Dimensaoy { get; set; }

    public string? Numeroprocesso { get; set; }

    public DateOnly Datacertidao { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    /// <summary>
    /// Condições Gerais
    /// </summary>
    public string? Conger { get; set; }

    /// <summary>
    /// Condições Específicas
    /// </summary>
    public string? Conesp { get; set; }

    public virtual Tipoveiculodivulgacao TipoveiculodivulgacaoNavigation { get; set; } = null!;
}
