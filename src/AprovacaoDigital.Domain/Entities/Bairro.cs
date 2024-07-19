using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Bairros]
/// 
/// filtersgrid[#text_filter,#text_filter]
/// gridtitle[Lista de Bairros]
/// </summary>
public class Bairro : BaseEntity
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
    public int Bairroid { get; set; }

    public string? Estado { get; set; }

    public int? Cidade { get; set; }

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

    public string? Abreviatura { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    public int? Regiaourbana { get; set; }

    public virtual Regiaourbana1? RegiaourbanaNavigation { get; set; }

    public virtual ICollection<Rua> RuaBairrofinalNavigations { get; set; } = new List<Rua>();

    public virtual ICollection<Rua> RuaBairroinicialNavigations { get; set; } = new List<Rua>();
}
