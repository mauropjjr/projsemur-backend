using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class ResiduosResiduo : BaseEntity
{
    public int Residuoid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public string? Nome { get; set; }

    public string? Obs { get; set; }

    public int? Estadofisico { get; set; }

    public int? Classificacao { get; set; }

    public int? Caracteristica { get; set; }

    public int? Numeroonu { get; set; }

    public int? Numerorisco { get; set; }

    public int? Armazenamento { get; set; }

    public string? Codigo { get; set; }

    public int? Autotransporte { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
