using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]
/// 
/// formtitle[Cadastro de Veículo de Divulgação]
/// filtersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Veículos de Divulgação]
/// </summary>
public class Veiculodivulgacao : BaseEntity
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
    public int Veiculodivulgacaoid { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Veículo Divulgação]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[tipoveiculodivulgacao.nome]
    /// 
    /// columngridid[tipoveiculodivulgacao.nome]
    /// columngridtitle[Tipo Veículo Divulgação]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Tipoveiculodivulgacao { get; set; }

    public int? Ocorrencia { get; set; }

    /// <summary>
    /// forminputlabel[Insc. Imobiliária]
    /// forminputsize[15]
    /// forminputclass[required]
    /// 
    /// columngridid[]
    /// columngridtitle[Insc. Imobiliária]
    /// columngridtype[ro]
    /// columngridsize[120]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Inscricaoimobiliaria { get; set; } = null!;

    /// <summary>
    /// forminputlabel[Insc. Econômica]
    /// forminputsize[15]
    /// forminputclass[required]
    /// 
    /// columngridid[]
    /// columngridtitle[Insc. Econômica]
    /// columngridtype[ro]
    /// columngridsize[120]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string Inscricaoeconomica { get; set; } = null!;

    /// <summary>
    /// 1 - SIM
    /// 2 - NÃO
    /// </summary>
    public int? Regular { get; set; }

    public decimal? Dimensaox { get; set; }

    public decimal? Dimensaoy { get; set; }

    /// <summary>
    /// ID do arquivo localizado no banco 10.0.0.148 - SADWEB.arqanx
    /// </summary>
    public int? Idarquivodivulgacao { get; set; }

    /// <summary>
    /// forminputlabel[CEP]
    /// forminputsize[10]
    /// forminputclass[number]
    /// 
    /// geragridmain[false]
    /// </summary>
    public int? Cep { get; set; }

    /// <summary>
    /// forminputlabel[N&amp;ordm; Processo]
    /// forminputsize[15]
    /// forminputclass[required]
    /// 
    /// columngridid[]
    /// columngridtitle[N&amp;ordm; Processo]
    /// columngridtype[ro]
    /// columngridsize[120]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Numeroprocesso { get; set; }

    /// <summary>
    /// forminputlabel[N&amp;ordm; Autorização]
    /// forminputsize[15]
    /// forminputclass[required]
    /// 
    /// columngridid[]
    /// columngridtitle[N&amp;ordm; Autorização]
    /// columngridtype[ro]
    /// columngridsize[120]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Numeroautorizacao { get; set; }

    /// <summary>
    /// forminputlabel[Data-Cadastro]
    /// forminputsize[12]
    /// forminputclass[data]
    /// 
    /// columngridid[]
    /// columngridtitle[Data-Cadastro]
    /// columngridtype[ro]
    /// columngridsize[110]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public DateOnly Datacadastro { get; set; }

    /// <summary>
    /// forminputlabel[Data-Prazo]
    /// forminputsize[12]
    /// forminputclass[data]
    /// 
    /// columngridid[]
    /// columngridtitle[Data-Prazo]
    /// columngridtype[ro]
    /// columngridsize[110]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public DateOnly Dataprazo { get; set; }

    /// <summary>
    /// forminputlabel[Latitude]
    /// forminputsize[12]
    /// forminputclass[ro]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// forminputlabel[Longitude]
    /// forminputsize[12]
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
    public int Unidadeaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int Version { get; set; }

    public string? Condesp { get; set; }

    /// <summary>
    /// Tipo de Processo
    /// </summary>
    public char? Tippro { get; set; }

    /// <summary>
    /// Numero da NAIN
    /// </summary>
    public int? Nronai { get; set; }

    /// <summary>
    /// Observação
    /// </summary>
    public string? Obsdiv { get; set; }

    /// <summary>
    /// Data de abertura do processo no protocolo
    /// </summary>
    public DateOnly? Datpro { get; set; }

    public virtual Ocorrencium? OcorrenciaNavigation { get; set; }

    public virtual Tipoveiculodivulgacao TipoveiculodivulgacaoNavigation { get; set; } = null!;
}
