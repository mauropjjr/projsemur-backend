

using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Infrastructure.Persistence.Context;
using AprovacaoDigital.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AprovacaoDigital.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DbprojsemurContext>(options =>
            //options.UseSqlite("Data Source=Teste.db")
            options.UseNpgsql(
                        configuration.GetConnectionString("DBPROJSEMUR"),
                         b => b.MigrationsAssembly(typeof(DbprojsemurContext).Assembly.FullName))
                );

            services.AddScoped<IUnitOfWork, UnitOfWork>();            
            services.AddScoped<IExigenciaRepository, ExigenciaRepository>();
            services.AddMemoryCache();
            services.AddScoped<ICacheService, MemoryCacheService>();

        }
    }
}
