using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Responsável]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Responsáveis]
/// </summary>
public class Empresa : BaseEntity
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
    public int Empresaid { get; set; }

    /// <summary>
    /// forminputlabel[Nome]
    /// forminputsize[50]
    /// forminputclass[uppercase]
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
    /// forminputlabel[Rua]
    /// forminputsize[12]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Rua { get; set; }

    /// <summary>
    /// forminputlabel[CEP]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Cep { get; set; }

    /// <summary>
    /// forminputlabel[N&amp;ordm;]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Numero { get; set; }

    /// <summary>
    /// forminputlabel[Complemento]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Complemento { get; set; }

    /// <summary>
    /// forminputlabel[Telefone]
    /// forminputsize[12]
    /// forminputclass[phone]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Telefone { get; set; }

    /// <summary>
    /// forminputlabel[Celular]
    /// forminputsize[12]
    /// forminputclass[phone]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Celular { get; set; }

    /// <summary>
    /// forminputlabel[Responsável]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Responsável]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Responsavel { get; set; }

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

    public virtual Rua? RuaNavigation { get; set; }
}
