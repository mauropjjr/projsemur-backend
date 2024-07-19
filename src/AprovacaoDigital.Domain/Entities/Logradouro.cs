using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Logradouro : BaseEntity
{
    public int Logradouroid { get; set; }

    public string? Nome { get; set; }
}
