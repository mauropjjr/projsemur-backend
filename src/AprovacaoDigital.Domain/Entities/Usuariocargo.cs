using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Usuariocargo : BaseEntity
{
    public int Usuariocargoid { get; set; }

    public int Usuario { get; set; }

    public string Cargo { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
