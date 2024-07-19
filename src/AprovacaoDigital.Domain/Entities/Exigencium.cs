using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Exigencium : BaseEntity
{
    public int Exigenciaid { get; set; }

    public string? Nome { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public string? Ordem { get; set; }

    public virtual ICollection<Remessaexigencium> Remessaexigencia { get; set; } = new List<Remessaexigencium>();
}
