using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Resíduo da Empresa]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Resíduos da Empresa]
/// </summary>
public class Empresaresiduo : BaseEntity
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
    public int Empresaresiduoid { get; set; }

    public int Empresa { get; set; }

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
    /// forminputlabel[Armazenamento]
    /// forminputsize[150]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[armazenamento.nome]
    /// 
    /// columngridid[armazenamento.nome]
    /// columngridtitle[Armazenamento]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Armazenamento { get; set; }

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

    public virtual Armazenamento ArmazenamentoNavigation { get; set; } = null!;

    public virtual Empresa2 EmpresaNavigation { get; set; } = null!;
}
