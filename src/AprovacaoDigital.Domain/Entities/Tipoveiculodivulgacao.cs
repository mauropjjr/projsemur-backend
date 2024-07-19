using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Tipo Veículo de Divulgação]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Tipos de Veículos de Divulgação]
/// </summary>
public class Tipoveiculodivulgacao : BaseEntity
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
    public int Tipoveiculodivulgacaoid { get; set; }

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
    /// forminputlabel[Lei]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Lei]
    /// columngridtype[ro]
    /// columngridsize[130]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Lei { get; set; }

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

    public virtual ICollection<Certidaoconformidade> Certidaoconformidades { get; set; } = new List<Certidaoconformidade>();

    public virtual ICollection<Certidao> Certidaos { get; set; } = new List<Certidao>();

    public virtual ICollection<Extrato> Extratos { get; set; } = new List<Extrato>();

    public virtual ICollection<Veiculodivulgacao> Veiculodivulgacaos { get; set; } = new List<Veiculodivulgacao>();
}
