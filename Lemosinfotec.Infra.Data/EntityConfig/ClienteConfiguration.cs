using Lemosinfotec.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Lemosinfotec.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x=>x.ClienteId);

            // builder.Property(x=>x.Data)
            // .HasColumnType("datetime")
            // .IsRequired();


            builder.Property(x=>x.Nome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.CPF)
            .HasColumnType("varchar(14)")
            .IsRequired();

            builder.Property(x=>x.CEP)
            .HasColumnType("varchar(30)")
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


            builder.Property(x=>x.VeiculoId);

             // 1 Cliente pode ter varios registros
            
            builder.HasOne(x=>x.Veiculo)
            .WithMany(x=>x.Cliente);
           
           
          
            
           
            
        }
    }
}
