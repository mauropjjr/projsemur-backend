using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro do Obra]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Obras]
/// 
/// masterdetails[true]
/// details[obradata,obraandamento]
/// </summary>
public class Obra : BaseEntity
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
    public int Obraid { get; set; }

    /// <summary>
    /// forminputlabel[Classificação] 
    /// forminputsize[100]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[70] 
    /// columngridtitle[Classificação] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int Classificacao { get; set; }

    /// <summary>
    /// forminputlabel[Descrição] 
    /// forminputsize[70]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Descrição] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Status] 
    /// forminputsize[20]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Status] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// forminputlabel[Valor Repasse] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Valor Repasse]
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public decimal? Valorrepasse { get; set; }

    /// <summary>
    /// forminputlabel[Valor Contra Partida] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Valor Contra Partida]
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public decimal? Valorcontrapartida { get; set; }

    /// <summary>
    /// forminputlabel[Valor Financiamento] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Valor Financiamento]
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public decimal? Valorfinanciamento { get; set; }

    /// <summary>
    /// forminputlabel[Contratado] 
    /// forminputsize[100]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Contratado] 
    /// columngridtype[ro] 
    /// columngridsize[70] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Contratado { get; set; }

    /// <summary>
    /// forminputlabel[Fiscal] 
    /// forminputsize[100]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Fiscal] 
    /// columngridtype[ro] 
    /// columngridsize[70] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Fiscal { get; set; }

    /// <summary>
    /// forminputlabel[Fase da Obra] 
    /// forminputsize[50]
    /// 
    /// searchmode[combobox] 
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Fase da Obra] 
    /// columngridtype[ro] 
    /// columngridsize[70] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Faseobra { get; set; }

    /// <summary>
    /// forminputlabel[Data Cadastro] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data Cadastro] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public DateOnly? Datacadastro { get; set; }

    /// <summary>
    /// forminputlabel[Data Previsão Entrega] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Data Previsão Entrega] 
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public DateOnly? Dataprevisaoentrega { get; set; }

    /// <summary>
    /// forminputlabel[Bairro] 
    /// forminputsize[100]
    /// 
    /// searchmode[popup] 
    /// popupresultfield[bairro.nome]
    /// popupfieldsgrid[bairroid,nome]
    /// 
    /// columngridid[] 
    /// columngridtitle[Bairro] 
    /// columngridtype[ro] 
    /// columngridsize[100] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int Bairro { get; set; }

    /// <summary>
    /// forminputlabel[Endereço] 
    /// forminputsize[70]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Endereço] 
    /// columngridtype[ro] 
    /// columngridsize[*] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// forminputlabel[Número] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Número] 
    /// columngridtype[ro] 
    /// columngridsize[30] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public int? Numero { get; set; }

    /// <summary>
    /// forminputlabel[Latitude] 
    /// forminputsize[20]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Latitude] 
    /// columngridtype[ro] 
    /// columngridsize[40] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// forminputlabel[Longitude] 
    /// forminputsize[20]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Longitude] 
    /// columngridtype[ro] 
    /// columngridsize[40] 
    /// columngridalign[left] 
    /// columngridcolor[white]
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
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// forminputlabel[Valor Investimento] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Valor Investimento]
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public decimal? Valorinvestimento { get; set; }

    /// <summary>
    /// forminputlabel[Valor Investimento] 
    /// forminputsize[10]  
    /// 
    /// columngridid[] 
    /// columngridtitle[Valor Investimento]
    /// columngridtype[ro] 
    /// columngridsize[20] 
    /// columngridalign[left] 
    /// columngridcolor[white]
    /// </summary>
    public decimal? Valorinvestimentopre { get; set; }

    public int? Recurso { get; set; }

    public int? Ministerio { get; set; }

    public int? Anoemenda { get; set; }

    public int? Evento { get; set; }

    public int? Fonterecurso { get; set; }

    public virtual Bairro1 BairroNavigation { get; set; } = null!;

    public virtual Classificacao1 ClassificacaoNavigation { get; set; } = null!;

    public virtual Contratado? ContratadoNavigation { get; set; }

    public virtual Evento? EventoNavigation { get; set; }

    public virtual Faseobra? FaseobraNavigation { get; set; }

    public virtual Fiscal? FiscalNavigation { get; set; }

    public virtual Fonterecurso? FonterecursoNavigation { get; set; }

    public virtual Ministerio? MinisterioNavigation { get; set; }

    public virtual ICollection<Obraandamento> Obraandamentos { get; set; } = new List<Obraandamento>();

    public virtual ICollection<Obradatum> Obradata { get; set; } = new List<Obradatum>();

    public virtual ICollection<Obraevento> Obraeventos { get; set; } = new List<Obraevento>();

    public virtual ICollection<Obraparlamentar> Obraparlamentars { get; set; } = new List<Obraparlamentar>();

    public virtual Recurso? RecursoNavigation { get; set; }

    public virtual Status2? StatusNavigation { get; set; }
}
