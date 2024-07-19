using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class ResiduosCtr : BaseEntity
{
    public int Ctrid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public DateTime? Datahoracadastro { get; set; }

    public DateTime? Datahoraentrega { get; set; }

    public string? Placaveiculo { get; set; }

    public double? Quantidade { get; set; }

    public string? Responsavel { get; set; }

    public int? Situacao { get; set; }

    public double? Transportadorasiat { get; set; }

    public int? Areareceptora { get; set; }

    public int? Armazenamento { get; set; }

    public int? Empresa { get; set; }

    public int? Residuo { get; set; }

    public int? Transportadora { get; set; }

    public int? Unidade { get; set; }

    public string? Nomecondutor { get; set; }

    public string? Obsdestfinal { get; set; }

    public int? Areareceptora2 { get; set; }

    public string? Obsdestfinal2 { get; set; }

    public int? Autotransporte { get; set; }

    public int? Numeromanifesto { get; set; }

    public int? Codigobaixa { get; set; }

    public DateTime? Datahoratransportadora { get; set; }

    public DateTime? Datahoradesfinal { get; set; }

    public DateTime? Datahorancertificado { get; set; }

    public DateTime? Datahorafinalizado { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
