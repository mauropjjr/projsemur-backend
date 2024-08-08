using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de CTR]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de CTR&apos;s]
/// </summary>
public class Ctr1 : BaseEntity
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
    /// forminputlabel[Data/Hora Cad.]
    /// forminputsize[14]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateTime Datahoracadastro { get; set; }

    public int? Empresa { get; set; }

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
    public int? Residuo { get; set; }

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

    /// <summary>
    /// forminputlabel[Armazenamento]
    /// forminputsize[110]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[armazenamento.nome]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Armazenamento { get; set; }

    /// <summary>
    /// forminputlabel[Área-Receptora]
    /// forminputsize[180]
    /// 
    /// searchmode[comboboxdet]
    /// comboboxresultfield[areareceptora.nome]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Areareceptora { get; set; }

    /// <summary>
    /// forminputlabel[Transportadora]
    /// forminputsize[180]
    /// 
    /// searchmode[comboboxdet]
    /// comboboxresultfield[transportadora.nome]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Transportadora { get; set; }

    /// <summary>
    /// forminputlabel[Transportadora-SIAT]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Transportadorasiat { get; set; }

    /// <summary>
    /// forminputlabel[Situação]
    /// forminputsize[10]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Situacao { get; set; }

    /// <summary>
    /// forminputlabel[Quantidade]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public decimal? Quantidade { get; set; }

    /// <summary>
    /// forminputlabel[Data/Hora Entrega]
    /// forminputsize[14]
    /// forminputclass[datetime]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateTime? Datahoraentrega { get; set; }

    /// <summary>
    /// forminputlabel[Responsável]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Nomecondutor { get; set; }

    /// <summary>
    /// forminputlabel[Placa Veículo]
    /// forminputsize[12]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Placaveiculo { get; set; }

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

    public virtual Areareceptora1? Areareceptora2Navigation { get; set; }

    public virtual Areareceptora1? AreareceptoraNavigation { get; set; }

    public virtual Armazenamento? ArmazenamentoNavigation { get; set; }

    public virtual ICollection<Ctrresiduo> Ctrresiduos { get; set; } = new List<Ctrresiduo>();

    public virtual Empresa2? EmpresaNavigation { get; set; }

    public virtual Transportadora? TransportadoraNavigation { get; set; }

    public virtual Unidade1? UnidadeNavigation { get; set; }
}
