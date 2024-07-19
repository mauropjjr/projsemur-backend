using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Documentos]
/// 
/// filtersgrid[#text_filter,#text_filter] 
/// 
/// 
/// gridtitle[Lista de Documentos]
/// 
/// </summary>
public class Documento : BaseEntity
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
    public int Documentoid { get; set; }

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
    /// forminputlabel[Caminho] 
    /// forminputsize[70]  
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Caminho { get; set; }

    /// <summary>
    /// forminputlabel[Situacao] 
    /// forminputsize[250]  
    /// 
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[situacao.descricao]
    /// 
    /// columngridid[situacao.descricao]
    /// columngridtitle[Situacao]
    /// columngridtype[ro]
    /// columngridsize[300]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Situacao { get; set; }

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
    /// forminputlabel[Remessa]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[remessa.titulo]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Remessa { get; set; }

    public int Arquivo { get; set; }

    public virtual Arquivo2 ArquivoNavigation { get; set; } = null!;

    public virtual Remessa RemessaNavigation { get; set; } = null!;

    public virtual Situacao SituacaoNavigation { get; set; } = null!;
}
