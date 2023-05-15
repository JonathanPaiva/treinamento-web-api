using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TreinamentoWebAPI.Domain;

namespace TreinamentoWebAPI.Data.Mappings
{
    public class SuperHeroiMap : IEntityTypeConfiguration<SuperHeroi>
    {
        public void Configure(EntityTypeBuilder<SuperHeroi> builder)
        {
            builder.ToTable("super_heroi");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ativo)
                .IsRequired()
                .HasDefaultValue(true)
                .HasColumnName("ativo");

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(80);

            builder.HasIndex(x => x.Nome).IsUnique();

            builder.Property(x => x.IdentidadeSecreta)
                .HasColumnName("identidade_secreta")
                .HasMaxLength(80);

            builder.Property(x => x.DataAparicao)
                .HasColumnName("data_aparicao");

            builder.Property(x => x.PoderId)
                .HasColumnName("poder_id");

            builder.HasOne(x => x.Poder)
                .WithMany(p => p.SuperHerois)
                    .HasForeignKey(x => x.PoderId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
