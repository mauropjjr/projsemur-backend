using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Resíduo da Área Receptora]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Resíduos da Área Receptora]
/// </summary>
public class Residuoarea : BaseEntity
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
    public int Residuoareaid { get; set; }

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
    /// forminputlabel[Área Receptora]
    /// forminputsize[150]
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
    public int Areareceptora { get; set; }

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

    public virtual Areareceptora1 AreareceptoraNavigation { get; set; } = null!;

    public virtual Residuo1 ResiduoNavigation { get; set; } = null!;
}
