using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Sistema]
/// 
/// fieldsgrid[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,versao:sistemaid]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// fieldsform[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,tema.temaid,tema.nome,urlfooter,urlheader,urllogo,urlmenuprincipal,usuariosonline,versao] 
///  
/// gridtitle[Lista de Sistemas]
/// </summary>
public class Sistema : BaseEntity
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
    public int Sistemaid { get; set; }

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
    /// forminputlabel[URL de teste] 
    /// forminputsize[50]  
    /// 
    /// columngridid[] 
    /// columngridtitle[URL de teste] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Urlteste { get; set; }

    /// <summary>
    /// forminputlabel[URL de produção] 
    /// forminputsize[50]  
    /// 
    /// columngridid[] 
    /// columngridtitle[URL de produção] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Urlproducao { get; set; }

    /// <summary>
    /// forminputlabel[Em produção] 
    /// forminputsize[50]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Em produção] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Emproducao { get; set; }

    /// <summary>
    /// forminputlabel[Em manutenção] 
    /// forminputsize[50]
    /// </summary>
    public int? Manutencao { get; set; }

    /// <summary>
    /// forminputlabel[Tema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// geragridmain[false]
    /// 
    /// columngridid[tema.nome]
    /// columngridtitle[Tema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Tema { get; set; }

    /// <summary>
    /// forminputlabel[URL footer] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Urlfooter { get; set; }

    /// <summary>
    /// forminputlabel[URL header] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Urlheader { get; set; }

    /// <summary>
    /// forminputlabel[URL logo] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Urllogo { get; set; }

    /// <summary>
    /// forminputlabel[URL Menu principal] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Urlmenuprincipal { get; set; }

    /// <summary>
    /// forminputlabel[Usuários online] 
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Usuariosonline { get; set; }

    /// <summary>
    /// forminputlabel[Versão] 
    /// forminputsize[50] 
    ///  
    /// columngridid[] 
    /// columngridtitle[Versão] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string Versao { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public DateTime? Restarttime { get; set; }

    public virtual ICollection<Grupousuario> Grupousuarios { get; set; } = new List<Grupousuario>();

    public virtual ICollection<Logacesso> Logacessos { get; set; } = new List<Logacesso>();

    public virtual ICollection<Logsistema> Logsistemas { get; set; } = new List<Logsistema>();

    public virtual ICollection<Modulosistema> Modulosistemas { get; set; } = new List<Modulosistema>();

    public virtual ICollection<Permissaoentidade> Permissaoentidades { get; set; } = new List<Permissaoentidade>();

    public virtual ICollection<Sistemacontexto> Sistemacontextos { get; set; } = new List<Sistemacontexto>();

    public virtual Tema TemaNavigation { get; set; } = null!;

    public virtual ICollection<Usuariosistema> Usuariosistemas { get; set; } = new List<Usuariosistema>();
}
