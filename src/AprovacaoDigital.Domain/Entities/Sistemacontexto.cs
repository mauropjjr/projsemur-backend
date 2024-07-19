using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Sistemacontexto : BaseEntity
{
    public int? Sistema { get; set; }

    public string? Contexto { get; set; }

    public bool Emproducao { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public int Sistemacontextoid { get; set; }

    public virtual Sistema? SistemaNavigation { get; set; }
}
