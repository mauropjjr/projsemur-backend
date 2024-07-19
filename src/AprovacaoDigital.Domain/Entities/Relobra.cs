using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Relobra : BaseEntity
{
    public string? Anomes { get; set; }

    public string? Nome { get; set; }

    public decimal? Valorinvestimento { get; set; }

    public string? Tempo { get; set; }

    public int? Total { get; set; }
}
