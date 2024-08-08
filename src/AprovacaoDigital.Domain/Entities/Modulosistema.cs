using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Módulos / Sistema]   
/// fieldsgrid[modulosistemaid,modulo.nome,sistema.nome:modulosistemaid] 
/// 
/// 
/// fieldsform[modulosistemaid,modulo.moduloid,modulo.nome,sistema.sistemaid,sistema.nome,manutencao] 
/// 
/// gridtitle[Lista de Módulos / Sistema]
/// </summary>
public class Modulosistema : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Modulosistemaid { get; set; }

    /// <summary>
    /// forminputlabel[Módulo]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[modulo.nome]
    /// columngridtitle[Módulo]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Modulo { get; set; }

    /// <summary>
    /// forminputlabel[Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[sistema.nome]
    /// columngridtitle[Sistema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Sistema { get; set; }

    public int Manutencao { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual ICollection<Arquivo> Arquivos { get; set; } = new List<Arquivo>();

    public virtual Modulo ModuloNavigation { get; set; } = null!;

    public virtual ICollection<Modulogrupo> Modulogrupos { get; set; } = new List<Modulogrupo>();

    public virtual ICollection<Modulosistemausuario> Modulosistemausuarios { get; set; } = new List<Modulosistemausuario>();

    public virtual Sistema SistemaNavigation { get; set; } = null!;
}
