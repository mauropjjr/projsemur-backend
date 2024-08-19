
using MediatR;

namespace AprovacaoDigital.Application.Features.Projeto.Create;

public class CreateProjetoRequest : IRequest<int>
{

    public DateTime? Datacriacao { get; set; }

    public DateTime? Datahomologacao { get; set; }

    public int? Profissional { get; set; }

    public int? Analista { get; set; }

    public DateTime? Dataencaminhamento { get; set; }

    public int? Finalizado { get; set; }

    public string Processo { get; set; } = null!;

    public string? Proprietario { get; set; }

    public string? Inscricao { get; set; }

    public int? Codificacao { get; set; }

    public long? Codseguranca { get; set; }

    public int? Assunto { get; set; }

    public string Processoexp { get; set; } = null!;

    public string? Alvara { get; set; }

    public int? Natureza { get; set; }

    public int? Atividade { get; set; }

    public string? Rua { get; set; }

    public int? Numero { get; set; }

    public string? Numart { get; set; }

    public int Status { get; set; }

    public int? Exportado { get; set; }

    public DateTime? Dataexportado { get; set; }

    public string? Quadra { get; set; }

    public string? Lote { get; set; }

    public string? Bairro { get; set; }

    public DateTime? Dataulttram { get; set; }

    public string? Despacho { get; set; }

    public string? Cpfproprietario { get; set; }

    public int? Numerolaudoavaliacao { get; set; }

    public int? Anolaudoavaliacao { get; set; }

    public decimal? Arealote { get; set; }

    public string? Lotefrente { get; set; }

    public string? Lotefundo { get; set; }

    public string? Lotedireita { get; set; }

    public string? Loteesquerda { get; set; }

    public decimal? Areaprojecao { get; set; }

    public string? Enquadramento1 { get; set; }

    public string? Enquadramento2 { get; set; }

    public string? Enquadramento3 { get; set; }

    public string? Enquadramento4 { get; set; }

    public string? Enquadramento5 { get; set; }

    public string? Enquadramento6 { get; set; }

    public string? Enquadramentofinal { get; set; }

    public decimal? Valormetroquadrado { get; set; }

    public int? Zoneamento { get; set; }

    public DateOnly? Datalaudoavaliacao { get; set; }

    public decimal? Areaexcedente { get; set; }

    public decimal? Valorcontrapartida { get; set; }

    public string? Valorcontrapartidaextenso { get; set; }

    public string? Valormetroquadradoextenso { get; set; }

    public decimal? Areax { get; set; }

    public decimal? Areay { get; set; }

    public string? Cnpjempresa { get; set; }

    public string? Razaosocialempresa { get; set; }

    public string? Proprietario1 { get; set; }

    public string? Proprietario2 { get; set; }

    public string? Proprietario3 { get; set; }

    public string? Cpfprop1 { get; set; }

    public string? Cpfprop2 { get; set; }

    public string? Cpfprop3 { get; set; }

    public string? Usuaval { get; set; }

    public string? Emailproprietario { get; set; }

    public string? Procsubstituto { get; set; }

    public int? Fiscal { get; set; }

    public int? Assuntoalt { get; set; }

    public int? Assuntogrup { get; set; }

    /// <summary>
    /// NOR = NORMAL(PADRAO)
    /// ESP = ESPECIAL
    /// APR = APROVE FACIL
    /// HAB = HABITE-SE LEGAL
    /// </summary>
    public string? Classificacao { get; set; }

    public int? Regiao { get; set; }

    public string? Telcontato { get; set; }

    public int? StatusAnistia { get; set; }

}

