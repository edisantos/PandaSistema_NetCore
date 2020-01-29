using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class TipoManutencaoConfiguration : IEntityTypeConfiguration<TipoManutencao>
    {
        public void Configure(EntityTypeBuilder<TipoManutencao> builder)
        {
            builder.ToTable("TipoManutencao");

            builder.HasKey(x=>x.TipoManuId);
            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.HasMany(x=>x.Registro)
            .WithOne(x=>x.TipoManutencao);

            

            
        }
    }
}
