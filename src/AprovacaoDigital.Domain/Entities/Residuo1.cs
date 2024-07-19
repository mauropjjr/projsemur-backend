using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Resíduo]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Resíduos]
/// </summary>
public class Residuo1 : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código]
    /// forminputsize[7]
    /// 
    /// columngridid[]
    /// columngridtitle[Código]
    /// columngridtype[ro]
    /// columngridsize[80]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Residuoid { get; set; }

    /// <summary>
    /// forminputlabel[Nome]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Nome]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Observação]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Obs { get; set; }

    /// <summary>
    /// forminputlabel[Estado Físico]
    /// forminputsize[150]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[estadofisico.nome]
    /// 
    /// columngridid[estadofisico.nome]
    /// columngridtitle[Estado Físico]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Estadofisico { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    public int? Classificacao { get; set; }

    public int? Caracteristica { get; set; }

    public int? Numeroonu { get; set; }

    public int? Numerorisco { get; set; }

    public int? Armazenamento { get; set; }

    public string? Codigo { get; set; }

    public int? Autotransporte { get; set; }

    public virtual Armazenamento? ArmazenamentoNavigation { get; set; }

    public virtual Caracteristica? CaracteristicaNavigation { get; set; }

    public virtual Classificacao? ClassificacaoNavigation { get; set; }

    public virtual Estadofisico EstadofisicoNavigation { get; set; } = null!;

    public virtual ICollection<Residuoarea> Residuoareas { get; set; } = new List<Residuoarea>();

    public virtual ICollection<Residuocaracteristica> Residuocaracteristicas { get; set; } = new List<Residuocaracteristica>();

    public virtual ICollection<Transportadoraresiduo> Transportadoraresiduos { get; set; } = new List<Transportadoraresiduo>();
}
