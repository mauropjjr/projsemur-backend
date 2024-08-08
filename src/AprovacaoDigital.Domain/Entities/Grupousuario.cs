using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Grupo / Usuário]
/// 
/// fieldsgrid[grupousuarioid,usuario.nome,grupo.nome,sistema.nome:grupousuarioid]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter] 
/// 
/// fieldsform[grupousuarioid,usuario.usuarioid,usuario.nome,grupo.grupoid,grupo.nome,sistema.sistemaid,sistema.nome] 
/// 
/// gridtitle[Lista de Grupos / Usuário]
/// </summary>
public class Grupousuario : BaseEntity
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
    public int Grupousuarioid { get; set; }

    /// <summary>
    /// forminputlabel[Usuário]
    /// forminputsize[50]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[usuarioid,nome,login,senha:usuarioid]
    /// 
    /// columngridid[usuario.nome]
    /// columngridtitle[Usuário]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Usuario { get; set; }

    /// <summary>
    /// forminputlabel[Grupo]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[grupo.nome]
    /// columngridtitle[Grupo]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Grupo { get; set; }

    /// <summary>
    /// forminputlabel[Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[sistema.nome]
    /// columngridtitle[Sistema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Sistema { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual Grupo GrupoNavigation { get; set; } = null!;

    public virtual Sistema? SistemaNavigation { get; set; }

    public virtual ICollection<Unidadeusuario> Unidadeusuarios { get; set; } = new List<Unidadeusuario>();

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
