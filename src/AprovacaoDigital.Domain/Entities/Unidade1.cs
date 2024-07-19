using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Unidade]
/// filtersgrid[#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Unidades]
/// </summary>
public class Unidade1 : BaseEntity
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

    public virtual ICollection<Ctr1> Ctr1s { get; set; } = new List<Ctr1>();

    public virtual ICollection<Ctrresiduo> CtrresiduoUnidadeNavigations { get; set; } = new List<Ctrresiduo>();

    public virtual ICollection<Ctrresiduo> CtrresiduoUnidadetransNavigations { get; set; } = new List<Ctrresiduo>();
}
