using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Ctrresiduo : BaseEntity
{
    public int Ctrresiduoid { get; set; }

    /// <summary>
    /// forminputlabel[Ctr]
    /// forminputsize[10]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Ctr { get; set; }

    /// <summary>
    /// forminputlabel[Resíduo]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// searchmode[popupdet]
    /// popupresultfield[nome]
    /// popupfieldsgrid[residuoid,nome,estadofisico.nome:residuoid]
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
    /// forminputlabel[Quantidade]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Quantidade]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Qtde { get; set; }

    /// <summary>
    /// forminputlabel[Unidade]
    /// forminputsize[110]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[unidade.nome]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Unidade { get; set; }

    public int? Qtdetrans { get; set; }

    /// <summary>
    /// forminputlabel[Unidade Transportadora]
    /// forminputsize[110]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[unidadetrans.nome]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Unidadetrans { get; set; }

    /// <summary>
    /// forminputlabel[Codigo Baixa]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Codigo Baixa]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Codigobaixa { get; set; }

    /// <summary>
    /// forminputlabel[Numero Manifesto]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Numero Manifesto]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Numeromanifesto { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    public virtual Ctr1 CtrNavigation { get; set; } = null!;

    public virtual Unidade1? UnidadeNavigation { get; set; }

    public virtual Unidade1? UnidadetransNavigation { get; set; }
}
