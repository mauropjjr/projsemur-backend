

using AprovacaoDigital.Application.Interfaces;
using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Infrastructure.Persistence.Context;
using AprovacaoDigital.Infrastructure.Persistence.Repositories;
using AprovacaoDigital.Infrastructure.Services;
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
            services.AddScoped<ITipoArquivoAgendaRepository, TipoArquivoAgendaRepository>();
            services.AddScoped<IAreaReceptoraRepository, AreaReceptoraRepository>();
            services.AddScoped<IAtividadeRepository, AtividadeRepository>();
            services.AddScoped<IZoneamentoRepository, ZoneamentoRepository>();
            services.AddScoped<IDestinoFinalRepository, DestinoFinalRepository>();
            services.AddScoped<ICodificacaoRepository, CodificacaoRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IAssuntoRepository, AssuntoRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IHistoricoRepository, HistoricoRepository>();
            services.AddMemoryCache();
            services.AddScoped<ICacheService, MemoryCacheService>();
            services.AddTransient<IHistoricoServices, HistoricoService>();

        }
    }
}
