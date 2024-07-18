using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AprovacaoDigital.Domain.Entities;

namespace AprovacaoDigital.Infrastructure.Persistence.Configurations;

public class TesteConfiguration : IEntityTypeConfiguration<Teste>
{
    public void Configure(EntityTypeBuilder<Teste> builder)
    {
        builder.Property(t => t.Descricao).IsRequired();
    }
}
