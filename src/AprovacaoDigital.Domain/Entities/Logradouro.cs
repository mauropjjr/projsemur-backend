using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Logradouro : BaseEntity
{
    public int Logradouroid { get; set; }

    public string? Nome { get; set; }
}
