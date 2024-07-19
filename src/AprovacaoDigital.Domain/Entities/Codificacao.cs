using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Codificacao : BaseEntity
{
    public int Codificacaoid { get; set; }

    public string? Nome { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Version { get; set; }

    public decimal? Fatoratual { get; set; }

    public int? Pontobase { get; set; }

    public int? Pontoanalise1 { get; set; }

    public int? Pontoanalise2 { get; set; }

    public int? Pontoanalise3 { get; set; }

    public int? Pontoanalise4 { get; set; }

    public int? Pontoanalise5 { get; set; }

    public int? Especial { get; set; }

    public virtual ICollection<Analiseprojeto> Analiseprojetos { get; set; } = new List<Analiseprojeto>();

    public virtual ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}
