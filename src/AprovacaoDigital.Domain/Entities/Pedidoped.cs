using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Pedidoped : BaseEntity
{
    /// <summary>
    /// Código do pedido
    /// </summary>
    public int Codigoped { get; set; }

    /// <summary>
    /// Solicitante do pedido
    /// </summary>
    public int? Codigosol { get; set; }

    /// <summary>
    /// Rua do pedido
    /// </summary>
    public string? Ruaped { get; set; }

    /// <summary>
    /// Numero da rua do pedido
    /// </summary>
    public string? Numeroped { get; set; }

    /// <summary>
    /// Bairro do pedido
    /// </summary>
    public string? Bairroped { get; set; }

    /// <summary>
    /// Complemento do endereço do pedido
    /// </summary>
    public string? Complemped { get; set; }

    /// <summary>
    /// CEP do solicitante no pedido
    /// </summary>
    public string? Cepped { get; set; }

    /// <summary>
    /// Quadra do pedido
    /// </summary>
    public string? Quadraped { get; set; }

    /// <summary>
    /// Lote do pedido
    /// </summary>
    public string? Loteped { get; set; }

    /// <summary>
    /// Data de cadastro do pedido
    /// </summary>
    public DateTime? Datacadped { get; set; }

    /// <summary>
    /// Micro-região
    /// </summary>
    public int? Codigomic { get; set; }

    /// <summary>
    /// Tipo da Solicitacao
    /// </summary>
    public int? Codigotps { get; set; }

    /// <summary>
    /// Numero do processo ou numero de identificação do pedido.
    /// </summary>
    public string? Processoped { get; set; }

    /// <summary>
    /// Origem do Pedido
    /// </summary>
    public int? Codigoori { get; set; }

    /// <summary>
    /// Tipo do Imovel do pedido
    /// </summary>
    public int? Codigotpi { get; set; }

    /// <summary>
    /// Justificativa do pedido
    /// </summary>
    public string? Justificaped { get; set; }
}
