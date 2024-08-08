
namespace AprovacaoDigital.Application.Common.Models;

public record BaseRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 30;
    public string CampoOrdem { get; set; }
    public string OrderBy { get; set; }
}
