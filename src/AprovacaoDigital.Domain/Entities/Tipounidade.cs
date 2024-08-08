using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Tipo de Unidade] 
/// 
/// fieldsgrid[tipounidadeid,nome:tipounidadeid]
/// filtersgrid[#text_filter,#text_filter] 
/// 
/// fieldsform[tipounidadeid,nome]
/// 
/// gridtitle[Lista de Tipos de Unidades]
/// </summary>
public class Tipounidade : BaseEntity
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
    public int Tipounidadeid { get; set; }

    /// <summary>
    /// forminputlabel[Nome]
    /// forminputsize[60]
    /// 
    /// columngridid[]
    /// columngridtitle[Nome]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Nome { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();
}
