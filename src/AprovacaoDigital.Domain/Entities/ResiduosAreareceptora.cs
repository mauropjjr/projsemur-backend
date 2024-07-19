using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class ResiduosAreareceptora : BaseEntity
{
    public int Areareceptoraid { get; set; }

    public int Rev { get; set; }

    public short? Revtype { get; set; }

    public int? Codigo { get; set; }

    public double? Inscricaomunicipal { get; set; }

    public string? Nome { get; set; }

    public int? Situacao { get; set; }

    public string? Telefone { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Numero { get; set; }

    public string? Rua { get; set; }

    public string? Bairro { get; set; }

    public string? Licencaambiental { get; set; }

    public DateOnly? Validadelicenca { get; set; }

    public int? Empresa { get; set; }

    public int? Transportadora { get; set; }

    public string? Senha { get; set; }

    public int? Usuario { get; set; }

    public virtual Revinfo RevNavigation { get; set; } = null!;
}
