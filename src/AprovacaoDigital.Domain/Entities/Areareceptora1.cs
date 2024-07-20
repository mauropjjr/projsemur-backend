using AprovacaoDigital.Domain.Common;

namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Área Receptora]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Áreas Receptoras]
/// </summary>
public class Areareceptora1 : BaseEntity
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
    public int Areareceptoraid { get; set; }

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
    /// forminputlabel[Situação]
    /// forminputsize[10]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Situacao { get; set; }

    /// <summary>
    /// forminputlabel[Código]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Codigo { get; set; }

    /// <summary>
    /// forminputlabel[Inscrição Municipal]
    /// forminputsize[15]
    /// forminputclass[inscricaomunicipal]
    /// 
    /// columngridid[]
    /// columngridtitle[Inscrição Municipal]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public decimal? Inscricaomunicipal { get; set; }

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

    public string? Telefone { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Rua { get; set; }

    public string? Licencaambiental { get; set; }

    public DateOnly? Validadelicenca { get; set; }

    public int? Empresa { get; set; }

    public int? Transportadora { get; set; }

    public string? Senha { get; set; }

    public int? Usuario { get; set; }

    public virtual ICollection<Ctr1> Ctr1Areareceptora2Navigations { get; set; } = new List<Ctr1>();

    public virtual ICollection<Ctr1> Ctr1AreareceptoraNavigations { get; set; } = new List<Ctr1>();

    public virtual Empresa2? EmpresaNavigation { get; set; }

    public virtual ICollection<Residuoarea> Residuoareas { get; set; } = new List<Residuoarea>();

    public virtual Transportadora? TransportadoraNavigation { get; set; }
}
