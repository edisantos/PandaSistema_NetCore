using System;
using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");
            builder.HasKey(x=>x.FornecedorId);

            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.CNPJ)
            .HasColumnType("varchar(30)")
            .IsRequired();

            builder.Property(x=>x.CEP)
            .HasColumnType("varchar(30")
            .IsRequired();

            builder.Property(x=>x.Endereco)
            .HasColumnType("varchar(100)")
            .IsRequired();

            builder.Property(x=>x.Cidade)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Uf)
            .HasColumnType("varchar(2)")
            .IsRequired();

            builder.HasMany(x=>x.Estoque)
            .WithOne(x=>x.Fornecedore);

        }
    }
}
