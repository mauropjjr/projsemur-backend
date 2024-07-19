using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Audit1 : BaseEntity
{
    public int Auditid { get; set; }

    public int? Sistema { get; set; }

    public int? Entidade { get; set; }

    public DateTime? Data { get; set; }

    public string? Strjson { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public int? Id { get; set; }

    public string? Tipomanutencao { get; set; }

    public string? Profissional { get; set; }
}
