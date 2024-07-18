using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace AprovacaoDigital.Infrastructure.Persistence.Context;

public class DataContext : DbContext
{
    public IConfiguration Configuration { get; private set; }
    public DataContext()
    {
        //  Configuration = configuration;
    }

    public DataContext(DbContextOptions<DataContext> options, IConfiguration _configuration) : base(options)
    {
        Configuration = _configuration;

    }
    
    public DbSet<Teste> Testes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //Gerar Seeds
        TesteSeeds.Configure(modelBuilder);



     
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetTableName(entityType.DisplayName());
            entityType.GetProperties()
            .Where(
                   p => p.ClrType == typeof(string)    // Entity is a string
                && p.GetColumnType() == null           // No column type is set
            ).ToList().ForEach(p => p.SetColumnType("varchar(255)"));

            entityType.GetForeignKeys()
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                .ToList()
                .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
        }


        base.OnModelCreating(modelBuilder);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {

        if (!options.IsConfigured)
        {
            //  options.UseSqlite(configuration.GetConnectionString("Sqlite"));
            options.UseSqlite("Data Source=Teste.db");
            // options.UseSqlServer(Configuration.GetConnectionString("PortalAdmin"),
            //options.UseNpgsql(@"Server=172.20.1.156\DEV;Database=PortalTCE;User ID=portaltce;Password=bQqABsUa5KeZ8fV;MultipleActiveResultSets=True;Integrated Security=False;Connect Timeout=60;TrustServerCertificate=True",
            //    providerOptions => { providerOptions.EnableRetryOnFailure(); });

        }
    }
    //Salvar usuario logado
    //https://github.com/veglos/dotnet-auth-microservice/tree/master/Auth.Domain
    //https://github.com/Amitpnk/Clean-Architecture-ASP.NET-Core/blob/develop/src/CleanArch.Persistence/Context/ApplicationDbContext.cs
    //public override int SaveChanges()
    //{
    //    return SaveChangesAsync().GetAwaiter().GetResult();
    //}
    //https://github.com/arbems/EF-Core-Repository-Unit-of-Work/blob/main/src/EFCoreRepositoryUnitofWork/Persistence/ApplicationContext.cs
    //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    //{
    //    var result = await base.SaveChangesAsync(cancellationToken);

    //    return result;
    //}

}



