using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Usuario x Unidade] 
/// 
/// fieldsgrid[usuariounidadeid,unidade.nome,usuario.nome:usuariounidadeid]
/// filtersgrid[#text_filter,#text_filter] 
/// 
/// fieldsform[usuariounidadeid,unidade.nome,usuario.nome]
/// 
/// gridtitle[Lista de Usuario x Unidade]
/// </summary>
public class Unidadeusuario : BaseEntity
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
    public int Unidadeusuarioid { get; set; }

    /// <summary>
    /// forminputlabel[Unidade]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[false]
    /// 
    /// </summary>
    public int? Unidade { get; set; }

    /// <summary>
    /// forminputlabel[Usuario]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[false]
    /// 
    /// </summary>
    public int? Usuario { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    /// <summary>
    /// forminputlabel[Grupo Usuario]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[false]
    /// 
    /// </summary>
    public int? Grupousuario { get; set; }

    public virtual Grupousuario? GrupousuarioNavigation { get; set; }

    public virtual Unidade? UnidadeNavigation { get; set; }

    public virtual Usuario? UsuarioNavigation { get; set; }
}
