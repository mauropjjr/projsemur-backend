using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Transportadora]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Transportadoras]
/// </summary>
public class Transportadora : BaseEntity
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
    public int Transportadoraid { get; set; }

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
    /// forminputlabel[CNPJ]
    /// forminputsize[10]
    /// 
    /// columngridid[]
    /// columngridtitle[CNPJ]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Cnpj { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Responsável]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Responsável]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Responsavel { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Telefone]
    /// forminputsize[12]
    /// forminputclass[phone]
    /// 
    /// columngridid[]
    /// columngridtitle[Telefone]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Telefone { get; set; } = null!;

    public string? Inscricaomunicipal { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geraformdet[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    public int? Ativo { get; set; }

    public string? Senha { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Bairro { get; set; }

    public string? Rua { get; set; }

    public string? Licencaambiental { get; set; }

    public DateOnly? Validadelicenca { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Areareceptora1> Areareceptora1s { get; set; } = new List<Areareceptora1>();

    public virtual ICollection<Ctr1> Ctr1s { get; set; } = new List<Ctr1>();

    public virtual ICollection<Transportadoraresiduo> Transportadoraresiduos { get; set; } = new List<Transportadoraresiduo>();
}
