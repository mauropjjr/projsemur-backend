using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Grupo]   
/// fieldsgrid[grupoid,nome:grupoid] 
/// 
/// fieldsform[grupoid,nome] 
/// 
/// gridtitle[Lista de Grupos]
/// </summary>
public class Grupo : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Grupoid { get; set; }

    /// <summary>
    /// forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]
    /// </summary>
    public string Nome { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual ICollection<Grupousuario> Grupousuarios { get; set; } = new List<Grupousuario>();

    public virtual ICollection<Modulogrupo> Modulogrupos { get; set; } = new List<Modulogrupo>();

    public virtual ICollection<Permissaoentidade> Permissaoentidades { get; set; } = new List<Permissaoentidade>();
}
