using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Característica de Resíduo]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Características do Resíduo]
/// </summary>
public class Residuocaracteristica : BaseEntity
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
    public int Residuocaracteristicaid { get; set; }

    /// <summary>
    /// forminputlabel[Resíduo]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[residuoid,nome:residuoid]
    /// 
    /// columngridid[residuo.nome]
    /// columngridtitle[Resíduo]
    /// columngridtype[ro]
    /// columngridsize[150]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Residuo { get; set; }

    /// <summary>
    /// forminputlabel[Característica]
    /// forminputsize[150]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[caracteristica.nome]
    /// 
    /// columngridid[caracteristica.nome]
    /// columngridtitle[Característica]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Caracteristica { get; set; }

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

    public virtual Caracteristica CaracteristicaNavigation { get; set; } = null!;

    public virtual Residuo1 ResiduoNavigation { get; set; } = null!;
}
