using AprovacaoDigital.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace  AprovacaoDigital.Infrastructure.Persistence.Seeds;

static class TesteSeeds
{
    public static void Configure(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Teste>().HasData(
           new Teste
           {
               Id = 1,
               Descricao = "teste",
           }

       );
    }
}
