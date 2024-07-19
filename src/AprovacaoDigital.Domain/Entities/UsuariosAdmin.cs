using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class UsuariosAdmin : BaseEntity
{
    public string? IdNome { get; set; }

    public string? Login { get; set; }

    public string? IdGrupo { get; set; }

    public string? NomeDoGrupo { get; set; }

    public string? NomeDoUsuário { get; set; }
}
