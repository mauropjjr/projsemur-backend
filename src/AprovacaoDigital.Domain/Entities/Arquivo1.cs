using AprovacaoDigital.Domain.Common;
using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Arquivo1 : BaseEntity
{
    /// <summary>
    /// Código do arquivo
    /// </summary>
    public int Arquivoid { get; set; }

    /// <summary>
    /// Conteudo do arquivo
    /// </summary>
    public byte[]? Conteudo { get; set; }

    /// <summary>
    /// Tipo do arquivo
    /// </summary>
    public int Tipoarquivo { get; set; }

    public virtual ICollection<Documento1> Documento1s { get; set; } = new List<Documento1>();

    public virtual Tipoarquivo TipoarquivoNavigation { get; set; } = null!;
}
