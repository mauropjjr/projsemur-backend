using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Usuários]   
/// fieldsgrid[usuarioid,nome,login,senha:usuarioid] 
/// fieldsform[usuarioid,nome,login,senha] 
/// 
/// gridtitle[Lista de Usuários]
/// </summary>
public class Usuario : BaseEntity
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
    public int Usuarioid { get; set; }

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
    /// forminputlabel[Login]
    /// forminputsize[20]
    /// </summary>
    public string Login { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Senha]
    /// forminputsize[20]
    /// </summary>
    public string Senha { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public string? Email { get; set; }

    public int? Tipocredid { get; set; }

    public virtual ICollection<Arquivousuario> Arquivousuarios { get; set; } = new List<Arquivousuario>();

    public virtual ICollection<Grupousuario> Grupousuarios { get; set; } = new List<Grupousuario>();

    public virtual ICollection<Logacesso> Logacessos { get; set; } = new List<Logacesso>();

    public virtual ICollection<Modulosistemausuario> Modulosistemausuarios { get; set; } = new List<Modulosistemausuario>();

    public virtual ICollection<Prfage> Prfages { get; set; } = new List<Prfage>();

    public virtual ICollection<Unidadeusuario> Unidadeusuarios { get; set; } = new List<Unidadeusuario>();

    public virtual ICollection<Usuariocargo> Usuariocargos { get; set; } = new List<Usuariocargo>();

    public virtual ICollection<Usuariosistema> Usuariosistemas { get; set; } = new List<Usuariosistema>();
}
