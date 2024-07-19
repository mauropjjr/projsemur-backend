using AprovacaoDigital.Domain.Common;
using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Área Receptora]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Áreas Receptoras]
/// </summary>
public class Areareceptora : BaseEntity
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
    public int Areareceptoraid { get; set; }

    /// <summary>
    /// 0-Ecoponto / 1-Ponto-Apoio
    /// 
    /// forminputlabel[Tipo]
    /// forminputsize[30]
    /// forminputclass[required]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int Tipo { get; set; }

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
    /// forminputlabel[N° Licença]
    /// forminputsize[20]
    /// forminputclass[number]
    /// 
    /// columngridid[]
    /// columngridtitle[N° Licença]
    /// columngridtype[ro]
    /// columngridsize[120]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Numerolicenca { get; set; } = null!;

    public int Regiao { get; set; }

    /// <summary>
    /// forminputlabel[Endereço]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// forminputlabel[N°]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Numero { get; set; }

    /// <summary>
    /// forminputlabel[Bairro]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// forminputlabel[Telefone]
    /// forminputsize[12]
    /// forminputclass[phone]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Telefone { get; set; }

    /// <summary>
    /// forminputlabel[latitude]
    /// forminputsize[10]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// forminputlabel[longitude]
    /// forminputsize[10]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Longitude { get; set; }

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

    public int? Ativo { get; set; }

    public virtual ICollection<Ctr> Ctrs { get; set; } = new List<Ctr>();
}
