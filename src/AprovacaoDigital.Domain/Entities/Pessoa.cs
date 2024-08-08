using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Pessoa : BaseEntity
{
    public int Pessoaid { get; set; }

    public string? Nome { get; set; }

    public string? Sobrenome { get; set; }

    public string? Email { get; set; }

    public string? Rg { get; set; }

    public string? Cpf { get; set; }

    public string? Telefone { get; set; }

    public int? Endereco { get; set; }

    public virtual Endereco? EnderecoNavigation { get; set; }
}
