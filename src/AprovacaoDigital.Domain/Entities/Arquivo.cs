using AprovacaoDigital.Domain.Common;
using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Arquivo]
/// fieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter] 
/// 
/// fieldsform[arquivoid,nome,url,modulo.moduloid,modulo.nome] 
/// 
/// gridtitle[Lista de Arquivos]
/// 
/// 
/// </summary>
public class Arquivo : BaseEntity
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
    public int Arquivoid { get; set; }

    /// <summary>
    /// forminputlabel[Nome] 
    /// forminputsize[50]  
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
    /// forminputlabel[URL] 
    /// forminputsize[50]
    /// </summary>
    public string Url { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Módulo Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[modulo.nome]
    /// 
    /// columngridid[modulosistema.modulo.nome]
    /// columngridtitle[Módulo Sistema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Modulosistema { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual ICollection<Arquivousuario> Arquivousuarios { get; set; } = new List<Arquivousuario>();

    public virtual Modulosistema ModulosistemaNavigation { get; set; } = null!;
}
