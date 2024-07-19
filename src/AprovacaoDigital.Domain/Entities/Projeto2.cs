using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Projeto2 : BaseEntity
{
    /// <summary>
    /// Código do PROJETO
    /// </summary>
    public int Projetoid { get; set; }

    /// <summary>
    /// Data de cadastro do Projeto
    /// </summary>
    public DateTime Datacadastro { get; set; }

    /// <summary>
    /// Inscrição Imobiliária
    /// </summary>
    public string Inscricao { get; set; } = null!;
}
