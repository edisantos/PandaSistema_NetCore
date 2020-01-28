using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class TipoPecasConfiguration : IEntityTypeConfiguration<TipoPeca>
    {
        public void Configure(EntityTypeBuilder<TipoPeca> builder)
        {
            builder.ToTable("TipoPecas");
            builder.HasKey(x=>x.TipoPecaId);

            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.HasMany(x=>x.Registro)
            .WithOne(x=>x.TipoPeca);
        }
    }
}
