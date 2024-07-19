using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Log de acesso]   
/// fieldsgrid[logacessoid,usuario.nome,sistema.nome,data,ip:logacessoid] 
/// 
/// fieldsform[logacessoid,usuario.usuarioid,usuario.nome,sistema.sistemaid,sistema.nome,data,ip] 
/// 
/// gridtitle[Lista de Logs de acesso]
/// </summary>
public class Logacesso : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Logacessoid { get; set; }

    /// <summary>
    /// forminputlabel[Usuario]
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
    public int? Usuario { get; set; }

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
    public int Sistema { get; set; }

    /// <summary>
    /// forminputlabel[Data] forminputsize[50]  columngridid[] columngridtitle[Data] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]
    /// </summary>
    public DateTime Data { get; set; }

    /// <summary>
    /// forminputlabel[IP] forminputsize[50]  columngridid[] columngridtitle[IP] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]
    /// </summary>
    public string Ip { get; set; } = null!;

    public int? Grupo { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual Sistema SistemaNavigation { get; set; } = null!;

    public virtual Usuario? UsuarioNavigation { get; set; }
}
