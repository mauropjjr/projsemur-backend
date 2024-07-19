using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;


namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class ExigenciaRepository : BaseRepository<Exigencia>, IExigenciaRepository
{
    public ExigenciaRepository(DbprojsemurContext context) : base(context)
    {
    }
}
