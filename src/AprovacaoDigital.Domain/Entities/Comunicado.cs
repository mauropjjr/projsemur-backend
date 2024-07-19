using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Comunicado : BaseEntity
{
    public int Comunicadoid { get; set; }

    public int Numerocomunicado { get; set; }

    public int Ano { get; set; }

    /// <summary>
    /// Inscrição Municpal
    /// </summary>
    public string? Inscricaoeconomica { get; set; }

    /// <summary>
    /// Localalidade de referência
    /// </summary>
    public string? Local { get; set; }

    /// <summary>
    /// Texto descritivo das exigências
    /// </summary>
    public string? Exigencia { get; set; }

    /// <summary>
    /// Funcionário que registra o comunicado
    /// </summary>
    public string? Registrado { get; set; }

    /// <summary>
    /// Cargo/Função
    /// </summary>
    public string? Cargo { get; set; }

    /// <summary>
    /// Usuario Logado (auditoria)
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// Grupo Logado (auditoria)
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// Unidade Logado (auditoria)
    /// </summary>
    public int? Unidadeaud { get; set; }

    /// <summary>
    /// Versao do registro (auditoria)
    /// </summary>
    public int? Version { get; set; }

    public string? Processo { get; set; }

    /// <summary>
    /// 1 - Indefirido
    /// 2 - Vistoria
    /// </summary>
    public int? Tipo { get; set; }
}
