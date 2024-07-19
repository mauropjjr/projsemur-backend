using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Remessa]
/// 
/// filtersgrid[#text_filter,#text_filter] 
/// 
/// 
/// gridtitle[Lista de Remessa]
/// 
/// masterdetails[true]
/// details[documento]
/// </summary>
public class Remessa : BaseEntity
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
    public int Remessaid { get; set; }

    /// <summary>
    /// forminputlabel[Titulo] 
    /// forminputsize[70]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Titulo] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Titulo { get; set; }

    /// <summary>
    /// forminputlabel[Data Criacao] 
    /// forminputsize[30]  
    /// forminputclass[datetime]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// forminputlabel[Descricao] 
    /// forminputsize[80]  
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Descricao { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// forminputlabel[Projeto]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[projeto.titulo]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Projeto { get; set; }

    public string? Remetente { get; set; }

    /// <summary>
    /// PROF - Remessa em construção pelo Profissional.
    /// CONF - Remessa Conferida pelo Ananalista/Supervisor
    /// FIN - Remessa finalizada pelo Profissional.
    /// RMF - Remessa Final
    /// </summary>
    public string? Status { get; set; }

    public int? Exigido { get; set; }

    public string? Despacho { get; set; }

    public string? Despachosemadur { get; set; }

    public DateTime? Datahoraexigencia { get; set; }

    public int? Analista { get; set; }

    public virtual Analistum? AnalistaNavigation { get; set; }

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual Projeto ProjetoNavigation { get; set; } = null!;

    public virtual ICollection<Remessaexigencia> Remessaexigencia { get; set; } = new List<Remessaexigencia>();
}
