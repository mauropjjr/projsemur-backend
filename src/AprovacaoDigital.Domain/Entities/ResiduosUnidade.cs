﻿using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class ResiduosUnidade : BaseEntity
{
    public int Unidadeid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public string? Nome { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}