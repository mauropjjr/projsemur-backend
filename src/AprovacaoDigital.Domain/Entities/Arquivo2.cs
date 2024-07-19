using AprovacaoDigital.Domain.Common;
using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Arquivo2 : BaseEntity
{
    public int Arquivoid { get; set; }

    public byte[]? Conteudo { get; set; }

    public int Tipoarquivo { get; set; }

    public int? Grupoaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public string? Caminho { get; set; }

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual Tipoarquivo1 TipoarquivoNavigation { get; set; } = null!;
}
