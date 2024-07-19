using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Tema]   
/// fieldsgrid[temaid,nome,url:temaid] 
/// fieldsform[temaid,nome,url] 
/// 
/// gridtitle[Lista de Temas]
/// </summary>
public class Tema : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Temaid { get; set; }

    /// <summary>
    /// forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// forminputlabel[URL] forminputsize[50]  columngridid[] columngridtitle[URL] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]
    /// </summary>
    public string Url { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual ICollection<Sistema> Sistemas { get; set; } = new List<Sistema>();

    public virtual ICollection<Usuariosistema> Usuariosistemas { get; set; } = new List<Usuariosistema>();
}
