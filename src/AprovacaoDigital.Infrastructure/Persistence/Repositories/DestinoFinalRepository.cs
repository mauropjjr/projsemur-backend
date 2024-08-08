using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;

namespace AprovacaoDigital.Infrastructure.Persistence.Repositories
{
    public class DestinoFinalRepository : BaseRepository<DestinoFinal>, IDestinoFinalRepository
    {

        public DestinoFinalRepository(DbprojsemurContext context, ICacheService cacheService) : base(context, cacheService)
        {
        }
    }
}
