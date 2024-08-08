using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Obra-Parlamentar]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Obra-Parlamentares]
/// </summary>
public class Obraparlamentar : BaseEntity
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
    /// columngridcolor[]
    /// </summary>
    public int Obraparlamentarid { get; set; }

    /// <summary>
    /// geragridmain[false]
    /// </summary>
    public int Obra { get; set; }

    /// <summary>
    /// forminputlabel[Parlamentar]
    /// forminputsize[70]
    /// 
    /// searchmode[popup]
    /// popupresultfield[parlamentar.nome]
    /// popupfieldsgrid[parlamentarid,nome]
    /// 
    /// columngridid[]
    /// columngridtitle[Parlamentar]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[]
    /// </summary>
    public int Parlamentar { get; set; }

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

    public string? Tipo { get; set; }

    public string? Anoemenda { get; set; }

    public virtual Obra ObraNavigation { get; set; } = null!;

    public virtual Parlamentar ParlamentarNavigation { get; set; } = null!;
}
