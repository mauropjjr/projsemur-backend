using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Tmpproc : BaseEntity
{
    public int Tmpprocid { get; set; }

    public string? Processo { get; set; }

    public string? Inscricao { get; set; }
}
