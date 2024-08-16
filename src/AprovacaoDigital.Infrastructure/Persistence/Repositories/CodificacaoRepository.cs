using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;

namespace AprovacaoDigital.Infrastructure.Persistence.Repositories
{
    public class CodificacaoRepository : BaseRepository<Codificacao>, ICodificacaoRepository
    {

        public CodificacaoRepository(DbprojsemurContext context, ICacheService cacheService) : base(context, cacheService)
        {
        }
    }
}
