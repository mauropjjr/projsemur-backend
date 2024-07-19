using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class PrfageTmp : BaseEntity
{
    public int? Codprf { get; set; }

    public long? Insprf { get; set; }

    public string? Nomprf { get; set; }

    public string? Titprf { get; set; }

    public string? Emlprf { get; set; }

    public long? Creprf { get; set; }

    public string? Ufcprf { get; set; }

    public string? Cpfprf { get; set; }

    public string? Fonprf { get; set; }

    public string? Tipprf { get; set; }

    public string? Nlcprf { get; set; }

    public string? Comprf { get; set; }

    public int? Numprf { get; set; }

    public string? Baiprf { get; set; }

    public string? Cepprf { get; set; }

    public string? Logprf { get; set; }

    public string? Senprf { get; set; }

    public DateOnly? Uacprf { get; set; }

    public int? Aceprf { get; set; }

    public int? Visprf { get; set; }

    public int? Usuario { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int Termoaceito { get; set; }
}
