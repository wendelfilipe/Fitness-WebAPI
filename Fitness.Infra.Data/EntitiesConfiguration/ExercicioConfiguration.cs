using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.Infra.Data.EntitiesConfiguration
{
    public class ExercicioConfiguration : IEntityTypeConfiguration<Exercicios>
    {
        public void Configure(EntityTypeBuilder<Exercicios> builder)
        {
            builder.ToTable("exercicios", "partion");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Created_at)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(e => e.Updated_at)
                .HasColumnName("updated_at");

            builder.Property(e => e.Deleted_at)
                .HasColumnName("deleted_at");

            builder.HasOne(e => e.Ficha)
                .WithMany(e => e.Exercicios)
                .HasForeignKey(e => e.FichaId);
        }
    }
}