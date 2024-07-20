using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

public class Assunto : BaseEntity
{
    /// <summary>
    /// Código do assunto
    /// </summary>
    public int Assuntoid { get; set; }

    /// <summary>
    /// Descrição do assunto
    /// </summary>
    public string Descricao { get; set; } = null!;

    public virtual ICollection<Projeto1> Projeto1s { get; set; } = new List<Projeto1>();
}
