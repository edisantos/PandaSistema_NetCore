using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("Registros");
            builder.HasKey(x=>x.id);

            // builder.Property(x=>x.Data)
            // .HasColumnType("datetime")
            // .IsRequired();

            builder.Property(x=>x.ClienteId);
            builder.Property(x=>x.TipoManutencaoId);
            builder.Property(x=>x.MecanicoId);
            builder.Property(x=>x.TipoPecaId);

            builder.Property(x=>x.Valor)
            .HasColumnType("decimal")
            .IsRequired();

            builder.Property(x=>x.Descricao)
            .HasColumnType("varchar(200)");

            
            builder.HasOne(x=>x.Cliente)
            .WithMany(x=>x.Registro);
            
            builder.HasOne(x=>x.TipoManutencao)
            .WithMany(x=>x.Registro);

            builder.HasOne(x=>x.TipoPeca)
            .WithMany(x=>x.Registro);

            
        

        
            
        }
    }
}
