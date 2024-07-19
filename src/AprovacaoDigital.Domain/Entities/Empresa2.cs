using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Empresa]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Empresas]
/// </summary>
public class Empresa2 : BaseEntity
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
    /// forminputlabel[Senha]
    /// forminputsize[10]
    /// forminputclass[]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Senha { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Data Licenciamento]
    /// forminputsize[10]
    /// forminputclass[date]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateOnly? Datalicenciamento { get; set; }

    /// <summary>
    /// forminputlabel[Nº Licenciamento]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Numerolicenciamento { get; set; }

    /// <summary>
    /// forminputlabel[Dt. Venc. Licenciamento]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public DateOnly? Datavenclicenciamento { get; set; }

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

    public string? Nome { get; set; }

    public string? Inscricaoeconomica { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Razaosocial { get; set; }

    public string? Email { get; set; }

    public string Inscricaomunicipal { get; set; } = null!;

    public virtual ICollection<Areareceptora1> Areareceptora1s { get; set; } = new List<Areareceptora1>();

    public virtual ICollection<Ctr1> Ctr1s { get; set; } = new List<Ctr1>();

    public virtual ICollection<Empresaresiduo> Empresaresiduos { get; set; } = new List<Empresaresiduo>();
}
