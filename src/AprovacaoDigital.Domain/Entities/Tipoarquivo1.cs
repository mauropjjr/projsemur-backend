using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Tipoarquivo1 : BaseEntity
{
    public int Tipoarquivoid { get; set; }

    public string? Nome { get; set; }

    public int? Grupoaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public string? Extension { get; set; }

    public string? Contenttype { get; set; }

    public int? Ativo { get; set; }

    public virtual ICollection<Arquivo2> Arquivo2s { get; set; } = new List<Arquivo2>();
}
