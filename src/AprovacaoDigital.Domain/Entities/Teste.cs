using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Teste : BaseEntity
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public DateTime? DateDeleted { get; set; }
}
