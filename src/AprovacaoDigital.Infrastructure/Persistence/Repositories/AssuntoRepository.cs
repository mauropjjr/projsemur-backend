using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class AssuntoRepository : BaseRepository<Assunto1>, IAssuntoRepository
{

    public AssuntoRepository(DbprojsemurContext context, ICacheService cacheService) : base(context, cacheService)
    {
    }
}