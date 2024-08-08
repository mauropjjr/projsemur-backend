using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Tipologradouro : BaseEntity
{
    public int Tipologradouroid { get; set; }

    public string? Nome { get; set; }
}
