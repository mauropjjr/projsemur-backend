namespace AprovacaoDigital.Application.Common.DTOs;

public class GetDocumentoRequest
{

    public int Id { get; set; }


    public string? Titulo { get; set; }

    public string? Caminho { get; set; }


    public int Situacao { get; set; }


    public int Remessa { get; set; }

    public int Arquivo { get; set; }

    public virtual GetArquivoRequest ArquivoNavigation { get; set; } = null!;

    public virtual GetRemessaRequest RemessaNavigation { get; set; } = null!;

    public virtual GetSituacaoRequest SituacaoNavigation { get; set; } = null!;
}

