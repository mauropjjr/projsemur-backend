using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// Status do projeto
/// </summary>
public class Status1 : BaseEntity
{
    /// <summary>
    /// Código do status
    /// </summary>
    public int Statusid { get; set; }

    /// <summary>
    /// Descrição do status
    /// </summary>
    public string Descricao { get; set; } = null!;

    public virtual ICollection<Projeto1> Projeto1s { get; set; } = new List<Projeto1>();
}
