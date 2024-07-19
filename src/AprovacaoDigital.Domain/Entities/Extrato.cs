using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Extrato : BaseEntity
{
    public int Extratoid { get; set; }

    public int Numeroextrato { get; set; }

    public int Ano { get; set; }

    /// <summary>
    /// Empresa - Requerente
    /// </summary>
    public string? Inscricaoeconomica { get; set; }

    /// <summary>
    /// Localidade pela inscrição imobiliária
    /// </summary>
    public string? Inscricaoimobiliaria { get; set; }

    /// <summary>
    /// Tipo de Veiculo de Divulgação
    /// </summary>
    public int Tipoveiculodivulgacao { get; set; }

    /// <summary>
    /// Processo
    /// </summary>
    public string? Processo { get; set; }

    /// <summary>
    /// Data do Processo
    /// </summary>
    public DateOnly? Dataprocesso { get; set; }

    /// <summary>
    /// 1-Autorização Definitiva
    /// 2-Uso nao Conforme
    /// </summary>
    public int? Tipoanalise { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public virtual Tipoveiculodivulgacao TipoveiculodivulgacaoNavigation { get; set; } = null!;
}
