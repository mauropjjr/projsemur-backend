using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Tipoarquivo : BaseEntity
{
    /// <summary>
    /// Código do tipo de arquivo
    /// </summary>
    public int Tipoarquivoid { get; set; }

    /// <summary>
    /// Descricao do tipo
    /// </summary>
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Extensão do arquivo
    /// </summary>
    public string? Extensao { get; set; }

    public virtual ICollection<Arquivo1> Arquivo1s { get; set; } = new List<Arquivo1>();
}
