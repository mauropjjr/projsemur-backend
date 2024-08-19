using AprovacaoDigital.Application.Features.TipoArquivo.GetAll;

namespace AprovacaoDigital.Application.Common.DTOs;

public class GetArquivoRequest
{
    public int Id { get; set; }

    public byte[]? Conteudo { get; set; }

    public int Tipoarquivo { get; set; }


    public string? Caminho { get; set; }

    public virtual ICollection<GetDocumentoRequest> Documentos { get; set; } = new List<GetDocumentoRequest>();

    public virtual GetAllTipoArquivoAgendaResponse TipoarquivoNavigation { get; set; } = null!;
}