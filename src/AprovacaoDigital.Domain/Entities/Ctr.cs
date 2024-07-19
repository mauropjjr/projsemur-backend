using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de CTR]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de CTR]
/// </summary>
public class Ctr : BaseEntity
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
    public int Ctrid { get; set; }

    /// <summary>
    /// forminputlabel[controleresiduo]
    /// forminputsize[15]
    /// forminputclass[]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Controleresiduo { get; set; }

    /// <summary>
    /// forminputlabel[Número-CTR]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Numeroctr { get; set; }

    /// <summary>
    /// forminputlabel[Transportadora]
    /// forminputsize[180]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[transportadora.nome]
    /// 
    /// columngridid[transportadora.nome]
    /// columngridtitle[Transportadora]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Transportador { get; set; }

    /// <summary>
    /// forminputlabel[Placa Veículo]
    /// forminputsize[15]
    /// forminputclass[required uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Placaveiculo { get; set; }

    /// <summary>
    /// forminputlabel[Nome Condutor]
    /// forminputsize[15]
    /// forminputclass[required uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Nomecondutor { get; set; }

    /// <summary>
    /// forminputlabel[Área Receptora]
    /// forminputsize[180]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[areareceptora.nome]
    /// 
    /// columngridid[areareceptora.nome]
    /// columngridtitle[Área Receptora]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Areareceptora { get; set; }

    /// <summary>
    /// forminputlabel[volume classe a]
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Volumeclassea { get; set; }

    /// <summary>
    /// forminputlabel[volume classe b]
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Volumeclasseb { get; set; }

    /// <summary>
    /// forminputlabel[volume classe c]
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Volumeclassec { get; set; }

    /// <summary>
    /// forminputlabel[volume classe d]
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Volumeclassed { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public int? Status { get; set; }

    public DateTime? Datahoracadastro { get; set; }

    public string? Proprietario { get; set; }

    public DateTime? Datahorabaixa { get; set; }

    public int? Prfage { get; set; }

    public string? Processo { get; set; }

    public virtual Areareceptora? AreareceptoraNavigation { get; set; }

    public virtual Prfage? PrfageNavigation { get; set; }

    public virtual Status? StatusNavigation { get; set; }

    public virtual Transportador? TransportadorNavigation { get; set; }
}
