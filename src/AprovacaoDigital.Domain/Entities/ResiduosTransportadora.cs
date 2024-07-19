using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class ResiduosTransportadora : BaseEntity
{
    public int Transportadoraid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public string? Cnpj { get; set; }

    public string? Inscricaomunicipal { get; set; }

    public string? Nome { get; set; }

    public string? Responsavel { get; set; }

    public string? Telefone { get; set; }

    public int? Ativo { get; set; }

    public string? Senha { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Rua { get; set; }

    public string? Bairro { get; set; }

    public string? Licencaambiental { get; set; }

    public DateOnly? Validadelicenca { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Email { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
