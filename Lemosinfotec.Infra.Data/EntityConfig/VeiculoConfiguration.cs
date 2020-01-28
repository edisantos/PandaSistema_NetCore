using System.Linq;
using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Veiculo");

            builder.HasKey(x=>x.VeiculoId);

            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Placa)
            .HasColumnType("varchar(7)")
            .IsRequired();

            
            
             
            

            
            
        }
    }
}
