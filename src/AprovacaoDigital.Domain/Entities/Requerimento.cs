using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Requerimento : BaseEntity
{
    /// <summary>
    /// Código do requerimento
    /// </summary>
    public int Requerimentoid { get; set; }

    /// <summary>
    /// Profissional requerente
    /// </summary>
    public int Profissional { get; set; }

    /// <summary>
    /// Proprietário requerente
    /// </summary>
    public string Proprietario { get; set; } = null!;

    /// <summary>
    /// Telefone do proprietário
    /// </summary>
    public string? Telproprietario { get; set; }

    /// <summary>
    /// Tipo do requerimento: GDU GDR GUIV
    /// </summary>
    public string Tiporequerimento { get; set; } = null!;

    /// <summary>
    /// Data de cadastro do requerimento
    /// </summary>
    public DateTime? Datacadastro { get; set; }

    /// <summary>
    /// Localização, endereço ou proximidade (exato ou aproximada)
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// Tipo de atividade/Empreendimento
    /// </summary>
    public int? Tipoatividade { get; set; }

    public virtual Profissional1 ProfissionalNavigation { get; set; } = null!;
}
