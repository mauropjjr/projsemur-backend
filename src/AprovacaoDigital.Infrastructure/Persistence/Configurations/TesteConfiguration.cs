using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AprovacaoDigital.Domain.Entities;

namespace AprovacaoDigital.Infrastructure.Persistence.Configurations;

public class TesteConfiguration : IEntityTypeConfiguration<TesteOld>
{
    public void Configure(EntityTypeBuilder<TesteOld> builder)
    {
        builder.Property(t => t.Descricao).IsRequired();
    }
}
