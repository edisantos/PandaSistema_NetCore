using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");

            builder.HasKey(x=>x.EstoqueId);

            builder.Property(x=>x.Quantidade)
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(x=>x.TipoPeca)
            .WithMany(x=>x.Estoque);

        }
    }
}
