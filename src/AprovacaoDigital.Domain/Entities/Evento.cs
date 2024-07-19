using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Evento]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Eventos]
/// </summary>
public class Evento : BaseEntity
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
    public int Eventoid { get; set; }

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
    /// forminputlabel[Data-Evento] 
    /// forminputsize[12]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data-Evento] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[]
    /// </summary>
    public DateOnly Dataevento { get; set; }

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

    public virtual ICollection<Obraevento> Obraeventos { get; set; } = new List<Obraevento>();

    public virtual ICollection<Obra> Obras { get; set; } = new List<Obra>();
}
