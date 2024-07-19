using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Tipologradouro : BaseEntity
{
    public int Tipologradouroid { get; set; }

    public string? Nome { get; set; }
}
