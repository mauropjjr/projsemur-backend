using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Projetoin : BaseEntity
{
    /// <summary>
    /// Código do projetoins
    /// </summary>
    public int Projetoinsid { get; set; }

    /// <summary>
    /// Inscrição imobiliaria
    /// </summary>
    public string Inscricao { get; set; } = null!;

    /// <summary>
    /// Projeto vinculado
    /// </summary>
    public int? Projeto { get; set; }

    /// <summary>
    /// Parcelamento
    /// </summary>
    public string? Parcelamento { get; set; }

    /// <summary>
    /// Quadra
    /// </summary>
    public string? Quadra { get; set; }

    /// <summary>
    /// Lote
    /// </summary>
    public string? Lote { get; set; }

    /// <summary>
    /// Bairro
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// Região
    /// </summary>
    public string? Regiao { get; set; }

    /// <summary>
    /// Logradouro
    /// </summary>
    public string? Logradouro { get; set; }

    /// <summary>
    /// Número do logradouro
    /// </summary>
    public string? Numero { get; set; }

    /// <summary>
    /// Complemento do logradouro
    /// </summary>
    public string? Compl { get; set; }

    /// <summary>
    /// Proprietario
    /// </summary>
    public string? Proprietario { get; set; }

    /// <summary>
    /// CPF ou CNPJ do proprietario
    /// </summary>
    public string? Cpfcnpj { get; set; }

    public virtual Projeto1? ProjetoNavigation { get; set; }
}
