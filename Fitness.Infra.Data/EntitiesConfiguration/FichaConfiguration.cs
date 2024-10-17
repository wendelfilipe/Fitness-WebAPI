using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.Infra.Data.EntitiesConfiguration
{
    public class FichaConfiguration : IEntityTypeConfiguration<Ficha>
    {
        public void Configure(EntityTypeBuilder<Ficha> builder)
        {
            builder.ToTable("ficha", "product");
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .HasColumnName("id");

            builder.Property(f => f.Name)
                .HasColumnName("name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Idade)
                .HasColumnName("idade")
                .IsRequired();

            builder.Property(f => f.Peso)
                .HasColumnName("peso");
            
            builder.Property(f => f.Altura)
                .HasColumnName("altura");

            builder.Property(f => f.Serie)
                .HasColumnName("serie")
                .IsRequired();

            builder.Property(f => f.Repeticao)
                .HasColumnName("repeticao")
                .IsRequired();

            builder.Property(f => f.Deleted_at)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(f => f.Updated_at)
                .HasColumnName("updated_at");
            
            builder.Property(f => f.Deleted_at)
                .HasColumnName("deleted_at");

        }
    }
}