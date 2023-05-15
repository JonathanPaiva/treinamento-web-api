using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TreinamentoWebAPI.Domain;

namespace TreinamentoWebAPI.Data.Mappings
{
    public class PoderMap : IEntityTypeConfiguration<Poder>
    {
        public void Configure(EntityTypeBuilder<Poder> builder)
        {
            builder.ToTable("poder");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Habilidade)
                .HasColumnName("habilidade")
                .IsRequired()
                .HasMaxLength(80);

            builder.HasIndex(x => x.Habilidade).IsUnique();
        }
    }
}
