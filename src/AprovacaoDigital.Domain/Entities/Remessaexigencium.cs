using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Remessaexigencium : BaseEntity
{
    public int Remessaexigenciaid { get; set; }

    public int Remessa { get; set; }

    public int? Exigencia { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }

    public string? Descricao { get; set; }

    public virtual Exigencium? ExigenciaNavigation { get; set; }

    public virtual Remessa RemessaNavigation { get; set; } = null!;
}
