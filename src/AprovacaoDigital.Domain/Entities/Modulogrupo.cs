using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Módulos / Grupo]   
/// fieldsgrid[modulogrupoid,grupo.nome,modulosistema.modulo.nome,menu:modulogrupoid] 
/// 
/// fieldsform[modulogrupoid,grupo.grupoid,grupo.nome,modulosistema.modulosistemaid,modulosistema.modulo.nome,menu] 
/// 
/// gridtitle[Lista de Módulos / Grupo]
/// </summary>
public class Modulogrupo : BaseEntity
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
    public int Modulogrupoid { get; set; }

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
    /// forminputlabel[Módulo Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[modulo.nome]
    /// 
    /// columngridid[modulosistema.modulo.nome]
    /// columngridtitle[Módulo Sistema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Modulosistema { get; set; }

    /// <summary>
    /// forminputlabel[MENU] 
    /// forminputsize[50]  
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Menu { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public string? Imagemtopo { get; set; }

    public virtual Grupo GrupoNavigation { get; set; } = null!;

    public virtual Modulosistema ModulosistemaNavigation { get; set; } = null!;
}
