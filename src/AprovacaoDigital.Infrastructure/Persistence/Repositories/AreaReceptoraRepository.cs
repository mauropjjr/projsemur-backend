using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;


namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class AreaReceptoraRepository : BaseRepository<AreaReceptora>, IAreaReceptoraRepository
{

    public AreaReceptoraRepository(DbprojsemurContext context, ICacheService cacheService) : base(context, cacheService)
    {
    }
}
