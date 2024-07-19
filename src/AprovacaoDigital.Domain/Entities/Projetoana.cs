using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Projetoana : BaseEntity
{
    /// <summary>
    /// Código do projetoana
    /// </summary>
    public int Projetoanaid { get; set; }

    /// <summary>
    /// Projeto vinculado
    /// </summary>
    public int? Projeto { get; set; }

    /// <summary>
    /// Analista vinculado
    /// </summary>
    public int? Analista { get; set; }

    /// <summary>
    /// Data do encaminhamento
    /// </summary>
    public DateTime? Dataencaminhado { get; set; }

    public virtual Analistum1? AnalistaNavigation { get; set; }

    public virtual Projeto1? ProjetoNavigation { get; set; }
}
