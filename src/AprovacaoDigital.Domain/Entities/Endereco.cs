using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Endereco : BaseEntity
{
    public int Enderecoid { get; set; }

    public int? Logradouro { get; set; }

    public int? Tipologradouro { get; set; }

    public int? Bairro { get; set; }

    public int? Numero { get; set; }

    public string? Cep { get; set; }

    public virtual ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
}
