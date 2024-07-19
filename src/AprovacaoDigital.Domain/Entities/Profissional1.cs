using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Infrastructure;

public class Profissional1 : BaseEntity
{
    /// <summary>
    /// Código do profissional
    /// </summary>
    public int Profissionalid { get; set; }

    /// <summary>
    /// Nome do profissional
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// CPF ou CNPJ do profissional
    /// </summary>
    public string Cpfcnpj { get; set; } = null!;

    /// <summary>
    /// Inscrição do profissional
    /// </summary>
    public string Inscricao { get; set; } = null!;

    /// <summary>
    /// email do profissional
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Telefone de contato 1
    /// </summary>
    public string? Telefone1 { get; set; }

    /// <summary>
    /// Telefone de contato 2
    /// </summary>
    public string? Telefone2 { get; set; }

    /// <summary>
    /// Endereço rua
    /// </summary>
    public string? Ruaend { get; set; }

    /// <summary>
    /// Endereço número
    /// </summary>
    public string? Numeroend { get; set; }

    /// <summary>
    /// Endereço bairro
    /// </summary>
    public string? Bairroend { get; set; }

    /// <summary>
    /// Endereço complemento
    /// </summary>
    public string? Complend { get; set; }

    /// <summary>
    /// Endereço cep
    /// </summary>
    public string? Cepend { get; set; }

    /// <summary>
    /// Endereço cidade
    /// </summary>
    public string? Cidadeend { get; set; }

    /// <summary>
    /// Endereço estado
    /// </summary>
    public string? Estadoend { get; set; }

    public virtual ICollection<Requerimento> Requerimentos { get; set; } = new List<Requerimento>();
}
