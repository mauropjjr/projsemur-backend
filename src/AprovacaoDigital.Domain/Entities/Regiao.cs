using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Regiao : BaseEntity
{
    public int Regiaoid { get; set; }

    public string Nome { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public virtual ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}
