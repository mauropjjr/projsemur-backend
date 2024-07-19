using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Unidade] 
/// 
/// fieldsgrid[unidadeid,nome:unidadeid]
/// filtersgrid[#text_filter,#text_filter] 
/// 
/// fieldsform[unidadeid,nome]
/// 
/// gridtitle[Lista de Unidades]
/// </summary>
public class Unidade : BaseEntity
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
    public int Unidadeid { get; set; }

    /// <summary>
    /// forminputlabel[Nome]
    /// forminputsize[60]
    /// 
    /// columngridid[]
    /// columngridtitle[Nome]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Nome { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Unidade]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[false]
    /// 
    /// </summary>
    public int? Tipounidade { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public virtual Tipounidade? TipounidadeNavigation { get; set; }

    public virtual ICollection<Unidadeusuario> Unidadeusuarios { get; set; } = new List<Unidadeusuario>();
}
