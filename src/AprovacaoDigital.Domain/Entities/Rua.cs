using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// 
/// 
/// formtitle[Cadastro de Rua]
/// 
/// filtersgrid[#text_filter,#text_filter]
/// 
/// 
/// 
/// gridtitle[Lista de Ruas]
/// </summary>
public class Rua : BaseEntity
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
    public int Ruaid { get; set; }

    public string? Estado { get; set; }

    public int? Cidade { get; set; }

    public int? Bairroinicial { get; set; }

    public int? Bairrofinal { get; set; }

    /// <summary>
    /// forminputlabel[Nome]
    /// forminputsize[70]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Nome]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Nome { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Tipo { get; set; }

    public string? Ativo { get; set; }

    public string? Nomepopular { get; set; }

    /// <summary>
    /// 
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// 
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// 
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// 
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    public virtual Bairro? BairrofinalNavigation { get; set; }

    public virtual Bairro? BairroinicialNavigation { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Proprietario> Proprietarios { get; set; } = new List<Proprietario>();
}
