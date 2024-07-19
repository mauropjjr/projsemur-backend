using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Aviso : BaseEntity
{
    public int Avisoid { get; set; }

    public DateTime? Datainicial { get; set; }

    public DateTime? Datafinal { get; set; }

    public int? Unidade { get; set; }

    public int? Grupo { get; set; }

    public int? Usuario { get; set; }

    public int? Sistema { get; set; }

    public int? Situacao { get; set; }

    public string? Mensagem { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }
}
