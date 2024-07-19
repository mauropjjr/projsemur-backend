using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Resíduo]
/// filtersgrid[#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Resíduos]
/// </summary>
public class Residuo : BaseEntity
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
    public int Residuoid { get; set; }

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
    /// forminputlabel[Classe]
    /// forminputsize[180]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[classe.nome]
    /// 
    /// columngridid[classe.nome]
    /// columngridtitle[Classe]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Classe { get; set; }

    /// <summary>
    /// 0-Sim / 1-Não
    /// 
    /// forminputlabel[Reutilização]
    /// forminputsize[30]
    /// forminputclass[required]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Reutilizacao { get; set; }

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

    public virtual Classe ClasseNavigation { get; set; } = null!;

    public virtual ICollection<Nomecoluna> Nomecolunas { get; set; } = new List<Nomecoluna>();

    public virtual ICollection<Valorcoluna> Valorcolunas { get; set; } = new List<Valorcoluna>();
}
