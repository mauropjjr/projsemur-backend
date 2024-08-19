using AprovacaoDigital.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovacaoDigital.Application.Common.DTOs;

public class GetSituacaoRequest { 
    public int Id { get; set; }

    public string? Descricao { get; set; }

//public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();
}