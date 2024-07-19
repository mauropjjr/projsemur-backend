using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Relatorio : BaseEntity
{
    public int? Relatorioid { get; set; }

    public int? Ordem { get; set; }

    public string? Regiaoimo { get; set; }

    public string? Bairroimo { get; set; }

    public string? Parcelamentoimo { get; set; }

    public string? Numeroautorizacao { get; set; }

    public string? Nomeempresa { get; set; }

    public DateOnly? Dataexpedicao { get; set; }

    public DateOnly? Prazo { get; set; }

    public string? Tipodivulgacao { get; set; }

    public string? Enderecoempresa { get; set; }

    public string? Enderecoimobiliaria { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public string? Inscricaoeconomica { get; set; }
}
