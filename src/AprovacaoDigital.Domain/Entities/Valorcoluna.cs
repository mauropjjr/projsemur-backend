using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Valor de Coluna]
/// filtersgrid[#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Valores de Coluna]
/// </summary>
public class Valorcoluna : BaseEntity
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
    public int Valorcolunaid { get; set; }

    /// <summary>
    /// forminputlabel[Coluna]
    /// forminputsize[180]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nomecoluna.nome]
    /// 
    /// columngridid[nomecoluna.nome]
    /// columngridtitle[Coluna]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Residuo { get; set; }

    /// <summary>
    /// forminputlabel[Controle-Resíduo]
    /// forminputsize[12]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Controleresiduo { get; set; }

    public string? Reutilizacao { get; set; }

    public string? Processo { get; set; }

    public string? Aplicacao { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? Construcao { get; set; }

    public decimal? Demolicao { get; set; }

    public decimal? Total { get; set; }

    public int? Destinofinal { get; set; }

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
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    public virtual Controleresiduo ControleresiduoNavigation { get; set; } = null!;

    public virtual Destinofinal? DestinofinalNavigation { get; set; }

    public virtual Residuo ResiduoNavigation { get; set; } = null!;
}
