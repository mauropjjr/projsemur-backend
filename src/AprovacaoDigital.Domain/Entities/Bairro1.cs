using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Bairro]
/// filtersgrid[#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Bairros]
/// </summary>
public class Bairro1 : BaseEntity
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

    /// <summary>
    /// forminputlabel[Nome] 
    /// forminputsize[70]  
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
    /// forminputlabel[Região Urbana] 
    /// forminputsize[100]
    /// 
    /// searchmode[popup] 
    /// popupresultfield[regiaourbana.nome]
    /// popupfieldsgrid[regiaourbanaid,nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Região Urbana] 
    /// columngridtype[ro] 
    /// columngridsize[100] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int Regiaourbana { get; set; }

    public virtual ICollection<Obra> Obras { get; set; } = new List<Obra>();

    public virtual Regiaourbana RegiaourbanaNavigation { get; set; } = null!;
}
