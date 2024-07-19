using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro do Andamento da Obra]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Andamentos da Obra]
/// </summary>
public class Obraandamento : BaseEntity
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
    public int Obraandamentoid { get; set; }

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
    public DateOnly Dataandamento { get; set; }

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
    public string Obs { get; set; } = null!;

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
    /// forminputlabel[Data Prazo] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data-Prazo] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public DateOnly? Dataprazo { get; set; }

    /// <summary>
    /// 1 - Andamento
    /// 2 - Concluída
    /// 3 - Cancelada
    /// 
    /// forminputlabel[Situação] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Situação] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Situacaoprazo { get; set; }

    /// <summary>
    /// forminputlabel[Data Situação] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data Situação] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public DateOnly? Datasituacao { get; set; }

    public virtual Obra ObraNavigation { get; set; } = null!;
}
