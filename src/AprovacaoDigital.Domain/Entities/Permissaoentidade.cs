using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Permissão/Entidade] 
/// 
/// fieldsgrid[permissaoentidadeid,sistema.nome,entidade.nome,grupo.nome:permissaoentidadeid]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter] 
/// 
/// fieldsform[permissaoentidadeid,sistema.sistemaid,sistema.nome,entidade.entidadeid,entidade.nome,grupo.grupoid,grupo.nome,grantentidade,denyentidade,grantcoluna,denycoluna,grantviewcoluna,denyviewcoluna] 
/// 
/// gridtitle[Lista de Permissão/Entidade]
/// </summary>
public class Permissaoentidade : BaseEntity
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
    public int Permissaoentidadeid { get; set; }

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
    /// forminputlabel[Entidade]
    /// forminputsize[50]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[entidadeid,nome:entidadeid]
    /// 
    /// geragridmain[true]
    /// 
    /// columngridid[entidade.nome]
    /// columngridtitle[Entidade]
    /// columngridtype[ro]
    /// columngridsize[180]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Entidade { get; set; }

    /// <summary>
    /// forminputlabel[Grupo]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[true]
    /// 
    /// columngridid[grupo.nome]
    /// columngridtitle[Grupo]
    /// columngridtype[ro]
    /// columngridsize[180]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Grupo { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public string? Grantinsert { get; set; }

    public string? Grantdelete { get; set; }

    public string? Grantupdate { get; set; }

    public string? Grantselect { get; set; }

    public string? Grantcoluna { get; set; }

    public string? Denycoluna { get; set; }

    public string? Grantviewcoluna { get; set; }

    public string? Denyviewcoluna { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public string? Physicaldeletion { get; set; }

    public string? Filtraunidade { get; set; }

    public string? Denyupdate { get; set; }

    public string? Denydelete { get; set; }

    public string? Denyview { get; set; }

    public string? Pathunidade { get; set; }

    public string? Pathusuario { get; set; }

    public string? Denyabas { get; set; }

    public string? Denycolumnsgrid { get; set; }

    public string? Denyfieldsform { get; set; }

    public string? Extrasinfo { get; set; }

    public string? Denyextrabuttons { get; set; }

    public virtual Entidade EntidadeNavigation { get; set; } = null!;

    public virtual Grupo GrupoNavigation { get; set; } = null!;

    public virtual Sistema SistemaNavigation { get; set; } = null!;
}
