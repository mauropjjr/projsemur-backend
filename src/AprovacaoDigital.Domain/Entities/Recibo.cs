﻿using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Recibo : BaseEntity
{
    public int Reciboid { get; set; }

    public int? Numero { get; set; }

    public string? Doador { get; set; }

    public string? Valor { get; set; }

    public string? Cpf { get; set; }
}