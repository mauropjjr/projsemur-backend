using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Revinfo : BaseEntity
{
    public int Id { get; set; }

    public long Timestamp { get; set; }

    public int Usuarioid { get; set; }

    public DateTime Datahoraalteracao { get; set; }

    public string Usuarionome { get; set; } = null!;

    public virtual ICollection<ResiduosAreareceptora> ResiduosAreareceptoras { get; set; } = new List<ResiduosAreareceptora>();

    public virtual ICollection<ResiduosArmazenamento> ResiduosArmazenamentos { get; set; } = new List<ResiduosArmazenamento>();

    public virtual ICollection<ResiduosCtrresiduo> ResiduosCtrresiduos { get; set; } = new List<ResiduosCtrresiduo>();

    public virtual ICollection<ResiduosCtr> ResiduosCtrs { get; set; } = new List<ResiduosCtr>();

    public virtual ICollection<ResiduosEmpresa> ResiduosEmpresas { get; set; } = new List<ResiduosEmpresa>();

    public virtual ICollection<ResiduosEstadofisico> ResiduosEstadofisicos { get; set; } = new List<ResiduosEstadofisico>();

    public virtual ICollection<ResiduosResiduo> ResiduosResiduos { get; set; } = new List<ResiduosResiduo>();

    public virtual ICollection<ResiduosTransportadora> ResiduosTransportadoras { get; set; } = new List<ResiduosTransportadora>();

    public virtual ICollection<ResiduosUnidade> ResiduosUnidades { get; set; } = new List<ResiduosUnidade>();
}
