﻿using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Tmpbairroregiao : BaseEntity
{
    public int Tmpbairroregiaoid { get; set; }

    public string? Parcelamento { get; set; }

    public string? Bairro { get; set; }

    public int? Bairroid { get; set; }

    public string? Regiao { get; set; }

    public int? Regiaoid { get; set; }
}
