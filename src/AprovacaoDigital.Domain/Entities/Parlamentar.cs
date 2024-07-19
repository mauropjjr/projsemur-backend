using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Parlamentar]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Parlamentares]
/// </summary>
public class Parlamentar : BaseEntity
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
    /// columngridcolor[]
    /// </summary>
    public int Parlamentarid { get; set; }

    /// <summary>
    /// forminputlabel[Nome] 
    /// forminputsize[70]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Nome] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[]
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Status] 
    /// forminputsize[12]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Status] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[]
    /// </summary>
    public string Status { get; set; } = null!;

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
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Mandato]
    /// forminputsize[150]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[]
    /// columngridtitle[Tipo Mandato]
    /// columngridtype[ro]
    /// columngridsize[70]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int? Tipomandato { get; set; }

    public virtual ICollection<Obraparlamentar> Obraparlamentars { get; set; } = new List<Obraparlamentar>();

    public virtual Tipomandato? TipomandatoNavigation { get; set; }
}
