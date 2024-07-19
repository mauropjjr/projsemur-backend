using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;


namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class TesteRepository : BaseRepository<TesteOld>, ITesteRepository
{
    public TesteRepository(DbprojsemurContext context) : base(context)
    {
    }

}
