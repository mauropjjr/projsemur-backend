using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class ResiduosEmpresa : BaseEntity
{
    public int Empresaid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public DateOnly? Datalicenciamento { get; set; }

    public DateOnly? Datavenclicenciamento { get; set; }

    public string? Inscricaomunicipal { get; set; }

    public int? Numerolicenciamento { get; set; }

    public string? Senha { get; set; }

    public string? Nome { get; set; }

    public string? Inscricaoeconomica { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Razaosocial { get; set; }

    public string? Email { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
