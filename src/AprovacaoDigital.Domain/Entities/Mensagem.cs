using System;
using System.Collections.Generic;

using AprovacaoDigital.Domain.Common; namespace AprovacaoDigital.Domain.Entities;

public class Mensagem : BaseEntity
{
    public int Mensagemid { get; set; }

    public int Projeto { get; set; }

    public DateTime Datahora { get; set; }

    public string Usuario { get; set; } = null!;

    public string Texto { get; set; } = null!;

    public int Lida { get; set; }

    public int Grupo { get; set; }

    public int Usuarioaud { get; set; }

    public int Grupoaud { get; set; }

    public int Unidadeaud { get; set; }

    public int Version { get; set; }
}
