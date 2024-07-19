using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Controle de Resíduo]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Controles de Resíduos]
/// </summary>
public class Controleresiduo : BaseEntity
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
    public int Controleresiduoid { get; set; }

    /// <summary>
    /// forminputlabel[Projeto]
    /// forminputsize[30]
    /// 
    /// searchmode[popup]
    /// popupresultfield[processo]
    /// popupfieldsgrid[projetoid,processo:projetoid]
    /// 
    /// columngridid[projeto.processo]
    /// columngridtitle[Projeto]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Projeto { get; set; }

    /// <summary>
    /// forminputlabel[Caracterização do Empreendimento]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[caracteristicaemp.nome]
    /// 
    /// columngridid[caracteristicaemp.nome]
    /// columngridtitle[Caracterização do Empreendimento]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Caracteristicaemp { get; set; }

    /// <summary>
    /// forminputlabel[Área Construção]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Construcaoarea { get; set; }

    /// <summary>
    /// forminputlabel[Volume Construção]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Contrucaovolume { get; set; }

    /// <summary>
    /// forminputlabel[Peso Construção]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Contrucaopeso { get; set; }

    /// <summary>
    /// forminputlabel[Volume Demolição]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Demolicaovolume { get; set; }

    /// <summary>
    /// forminputlabel[Peso Demolição]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Demolicaopeso { get; set; }

    /// <summary>
    /// forminputlabel[Volume Bota-fora]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Botaforavolume { get; set; }

    /// <summary>
    /// forminputlabel[Peso Bota-fora]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Botaforapeso { get; set; }

    /// <summary>
    /// forminputlabel[Volume Empréstimo]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Emprestvolume { get; set; }

    /// <summary>
    /// forminputlabel[Peso Empréstimo]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal Emprestpeso { get; set; }

    /// <summary>
    /// 0-Sim / 1-Nao
    /// forminputlabel[Haverá Segregação do material no canteiro de obras?]
    /// forminputsize[15]
    /// forminputclass[required number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Segregacaomat { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    /// <summary>
    /// forminputlabel[Status]
    /// forminputsize[180]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[status.descricao]
    /// 
    /// columngridid[status.descricao]
    /// columngridtitle[Status]
    /// columngridtype[ro]
    /// columngridsize[50]
    /// columngridalign[left]
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// forminputlabel[Data Cadastro]
    /// forminputsize[15]
    /// forminputclass[]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateTime? Datahoracadastro { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public string? Proprietario { get; set; }

    public int? Prfage { get; set; }

    public virtual Caracteristicaemp CaracteristicaempNavigation { get; set; } = null!;

    public virtual Prfage ControleresiduoNavigation { get; set; } = null!;

    public virtual Status? StatusNavigation { get; set; }

    public virtual ICollection<Valorcoluna> Valorcolunas { get; set; } = new List<Valorcoluna>();
}
