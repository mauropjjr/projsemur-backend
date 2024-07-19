using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Profissional : BaseEntity
{
    public int Profissionalid { get; set; }

    public string? Inscricao { get; set; }

    public string? Titulo { get; set; }

    public string? Numerocre { get; set; }

    public string? Ufcre { get; set; }

    public string? Telefone { get; set; }
}
