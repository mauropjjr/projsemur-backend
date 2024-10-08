﻿using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class ResiduosArmazenamento : BaseEntity
{
    public int Armazenamentoid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public string? Nome { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
