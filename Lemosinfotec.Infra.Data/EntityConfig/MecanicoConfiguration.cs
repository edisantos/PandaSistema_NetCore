using System;
using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class MecanicoConfiguration : IEntityTypeConfiguration<Mecanico>
    {
        public void Configure(EntityTypeBuilder<Mecanico> builder)
        {
            builder.ToTable("Mecanicos");
            builder.HasKey(x=>x.MecanicoId);

            builder.Property(x=>x.Data)
            .HasColumnType("datetime")
            .IsRequired();

            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.HasMany(x=>x.Registro)
            .WithOne(x=>x.Mecanico);
        }
    }
}
