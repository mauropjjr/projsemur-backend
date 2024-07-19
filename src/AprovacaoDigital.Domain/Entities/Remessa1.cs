using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Remessa1 : BaseEntity
{
    /// <summary>
    /// Código da remessa
    /// </summary>
    public int Remessaid { get; set; }

    /// <summary>
    /// Descrição da remessa
    /// </summary>
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Data de cadastro da remessa
    /// </summary>
    public DateTime Data { get; set; }

    /// <summary>
    /// Projeto vinculado
    /// </summary>
    public int Projeto { get; set; }

    /// <summary>
    /// Analista vinculado que analisou a remessa
    /// </summary>
    public int? Analista { get; set; }

    /// <summary>
    /// Status da remessa, FIN = FINALIZADA , ANA = EM ANALISE
    /// </summary>
    public string Status { get; set; } = null!;

    public virtual Analistum1? AnalistaNavigation { get; set; }

    public virtual ICollection<Documento1> Documento1s { get; set; } = new List<Documento1>();

    public virtual Projeto1 ProjetoNavigation { get; set; } = null!;
}
