using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Transportador]
/// filtersgrid[#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Transportadores]
/// </summary>
public class Transportador : BaseEntity
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
    public int Transportadorid { get; set; }

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
    /// forminputlabel[Endereço]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Endereco { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Telefone]
    /// forminputsize[12]
    /// forminputclass[phone]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Telefone { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Cadastro Municipal]
    /// forminputsize[20]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Cadmunicipal { get; set; } = null!;

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
    public int Version { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    public DateOnly? Datavalidade { get; set; }

    public DateOnly? Datacadastro { get; set; }

    public int Ativo { get; set; }

    public string? Rua { get; set; }

    public string? Cep { get; set; }

    public virtual ICollection<Ctr> Ctrs { get; set; } = new List<Ctr>();
}
