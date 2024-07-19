using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Tmpproc : BaseEntity
{
    public int Tmpprocid { get; set; }

    public string? Processo { get; set; }

    public string? Inscricao { get; set; }
}
