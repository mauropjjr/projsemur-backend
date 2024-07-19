using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Usuários / Sistema]   
/// 
/// fieldsgrid[usuariosistemaid,sistema.nome,usuario.nome,tema.nome,qtdeacessos:usuariosistemaid] 
/// fieldsform[usuariosistemaid,sistema.sistemaid,sistema.nome,usuario.usuarioid,usuario.nome,tema.temaid,tema.nome,qtdeacessos,ultimoacesso,dataexpiracao]
/// 
/// gridtitle[Lista de Usuários / Sistema]
/// </summary>
public class Usuariosistema : BaseEntity
{
    public int Usuariosistemaid { get; set; }

    /// <summary>
    /// forminputlabel[Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[true]
    /// 
    /// columngridid[sistema.nome]
    /// columngridtitle[Sistema]
    /// columngridtype[ro]
    /// columngridsize[180]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Sistema { get; set; }

    /// <summary>
    /// forminputlabel[Usuário]
    /// forminputsize[50]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[usuarioid,nome,login,senha:usuarioid]
    /// 
    /// geragridmain[true]
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
    /// forminputlabel[Tema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[true]
    /// 
    /// columngridid[tema.nome]
    /// columngridtitle[Tema]
    /// columngridtype[ro]
    /// columngridsize[180]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Tema { get; set; }

    /// <summary>
    /// forminputlabel[Expiração de acesso] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateTime? Dataexpiracao { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual Sistema SistemaNavigation { get; set; } = null!;

    public virtual Tema? TemaNavigation { get; set; }

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
