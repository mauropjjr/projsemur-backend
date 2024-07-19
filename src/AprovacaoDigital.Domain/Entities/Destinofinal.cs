using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Destinofinal : BaseEntity
{
    public int Destinofinalid { get; set; }

    public string? Nome { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public virtual ICollection<Valorcoluna> Valorcolunas { get; set; } = new List<Valorcoluna>();
}
