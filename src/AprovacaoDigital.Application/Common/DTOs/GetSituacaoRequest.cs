namespace AprovacaoDigital.Application.Common.DTOs;

public class GetSituacaoRequest
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    //public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();
}