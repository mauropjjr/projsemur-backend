using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Modulo/ Sistema / Usuário]   
/// fieldsgrid[modulosistemausuarioid,modulosistema.modulo.nome,usuario.nome:modulosistemausuarioid] 
/// 
/// fieldsform[modulosistemausuarioid,modulosistema.modulosistemaid,modulosistema.modulo.nome,usuario.usuarioid,usuario.nome,grantmodulo,denymodulo] 
/// 
/// gridtitle[Lista de Modulo/ Sistema / Usuário]   
/// </summary>
public class Modulosistemausuario : BaseEntity
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
    public int Modulosistemausuarioid { get; set; }

    /// <summary>
    /// forminputlabel[ModuloSistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[modulosistema.modulo.nome]
    /// 
    /// geragridmain[true]
    /// 
    /// columngridid[modulosistema.modulo.nome]
    /// columngridtitle[Modulo Sistema]
    /// columngridtype[ro]
    /// columngridsize[180]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Modulosistema { get; set; }

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
    /// forminputlabel[GrantModulo]
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Grantmodulo { get; set; } = null!;

    /// <summary>
    /// forminputlabel[DenyModulo]
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Denymodulo { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual Modulosistema ModulosistemaNavigation { get; set; } = null!;

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
