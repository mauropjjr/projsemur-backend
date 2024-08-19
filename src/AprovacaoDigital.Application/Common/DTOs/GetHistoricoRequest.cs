using AprovacaoDigital.Application.Features.Projeto.Get;


namespace AprovacaoDigital.Application.Common.DTOs;

public class GetHistoricoRequest
{
    public int Id { get; set; }

    public int Projeto { get; set; }

    public DateTime Datahora { get; set; }

    public int Sequencia { get; set; }

    public string Despacho { get; set; } = null!;

    public string Autor { get; set; } = null!;


    public int? Exportado { get; set; }

    public DateTime? Dataexportado { get; set; }

    public virtual GetProjetoResponse ProjetoNavigation { get; set; } = null!;
}
