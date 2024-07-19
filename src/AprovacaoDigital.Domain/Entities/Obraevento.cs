using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Obra-Evento]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Obra-Eventos]
/// </summary>
public class Obraevento : BaseEntity
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
    public int Obraeventoid { get; set; }

    /// <summary>
    /// geragridmain[false]
    /// </summary>
    public int Obra { get; set; }

    /// <summary>
    /// forminputlabel[Evento]
    /// forminputsize[70]
    /// 
    /// searchmode[popup]
    /// popupresultfield[evento.nome]
    /// popupfieldsgrid[eventoid,nome]
    /// 
    /// columngridid[]
    /// columngridtitle[Evento]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[]
    /// </summary>
    public int Evento { get; set; }

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

    public virtual Evento EventoNavigation { get; set; } = null!;

    public virtual Obra ObraNavigation { get; set; } = null!;
}
