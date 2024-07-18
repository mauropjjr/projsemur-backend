

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

            services.AddDbContext<DataContext>(options =>
            options.UseSqlite("Data Source=Teste.db")
            //options.UseNpgsql(
            //            configuration.GetConnectionString("Banco"),
            //             b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName))
                );

            services.AddScoped<IUnitOfWork, UnitOfWork>();            
            services.AddScoped<ITesteRepository, TesteRepository>();

        }
    }
}
