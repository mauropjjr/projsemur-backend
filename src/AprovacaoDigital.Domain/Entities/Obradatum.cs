using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro do Andamento da Obra]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Andamentos da Obra]
/// </summary>
public class Obradatum : BaseEntity
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
    public int Obradataid { get; set; }

    /// <summary>
    /// forminputlabel[Obra] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Obra] 
    /// columngridtype[ro] 
    /// columngridsize[10] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int Obra { get; set; }

    /// <summary>
    /// forminputlabel[Data] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public DateOnly Data { get; set; }

    /// <summary>
    /// forminputlabel[Status] 
    /// forminputsize[20]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Status] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Controle] 
    /// forminputsize[20]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Tipo Controle] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Tipocontrole { get; set; }

    /// <summary>
    /// forminputlabel[Nº Controle] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Nº Controle] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Controle { get; set; }

    /// <summary>
    /// forminputlabel[Observação] 
    /// forminputsize[70]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Observação] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Obs { get; set; }

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

    public virtual Obra ObraNavigation { get; set; } = null!;

    public virtual Status2 StatusNavigation { get; set; } = null!;

    public virtual Tipocontrole? TipocontroleNavigation { get; set; }
}
