using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Certidaoconformidade : BaseEntity
{
    public int Certidaoconid { get; set; }

    public int Numerocertidaocon { get; set; }

    public int Ano { get; set; }

    public int Tipoveiculodivulgacao { get; set; }

    public string Inscricaoimobiliaria { get; set; } = null!;

    public int? Cep { get; set; }

    public string? Numeroprocesso { get; set; }

    public DateOnly Datacertidao { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public virtual Tipoveiculodivulgacao TipoveiculodivulgacaoNavigation { get; set; } = null!;
}
