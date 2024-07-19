using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Assunto1 : BaseEntity
{
    public int Assuntoid { get; set; }

    public string Nome { get; set; } = null!;

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    public virtual ICollection<Projeto> ProjetoAssuntoNavigations { get; set; } = new List<Projeto>();

    public virtual ICollection<Projeto> ProjetoAssuntoaltNavigations { get; set; } = new List<Projeto>();
}
