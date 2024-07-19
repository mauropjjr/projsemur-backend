using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Projeto1 : BaseEntity
{
    /// <summary>
    /// Código do projeto
    /// </summary>
    public int Projetoid { get; set; }

    /// <summary>
    /// Data de cadastro
    /// </summary>
    public DateTime Datacadastro { get; set; }

    /// <summary>
    /// Número do processo
    /// </summary>
    public string Processo { get; set; } = null!;

    /// <summary>
    /// Assunto do projeto
    /// </summary>
    public int Assunto { get; set; }

    /// <summary>
    /// Status do projeto
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// Data de aprovação(homologação)
    /// </summary>
    public DateTime? Datahomologacao { get; set; }

    public virtual Assunto AssuntoNavigation { get; set; } = null!;

    public virtual ICollection<Projetoana> Projetoanas { get; set; } = new List<Projetoana>();

    public virtual ICollection<Projetoin> Projetoins { get; set; } = new List<Projetoin>();

    public virtual ICollection<Remessa1> Remessa1s { get; set; } = new List<Remessa1>();

    public virtual Status1 StatusNavigation { get; set; } = null!;
}
