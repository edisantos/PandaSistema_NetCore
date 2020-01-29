using Lemosinfotec.Domain.Entidades;
using Lemosinfotec.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Lemosinfotec.Infra.Data.Contexto
{
    public class DataContexto : DbContext
    {
        //Entidades (Coloque aqui)
        public DbSet<Registro> Retistros{get;set;}
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<Veiculo> Veiculos{get;set;}
        public DbSet<Marca> Marcas{get;set;}
        public DbSet<TipoManutencao> TipoManutencao{get;set;}
        public DbSet<TipoPeca> TipoPecas{get;set;}
        public DbSet<Fornecedor> Fornecedores{get;set;}
        public DbSet<Estoque> Estoque {get;set;}
        public DbSet<Mecanico> Mecanicos{get;set;}

        //Fim Entidades

        /*Metodo Conexao EntityFrameworkCore*/
        public DataContexto( DbContextOptions<DataContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder){

            builder.ApplyConfiguration(new ClienteConfiguration());
            builder.ApplyConfiguration(new EstoqueConfiguration());
            builder.ApplyConfiguration(new FornecedorConfiguration());
            builder.ApplyConfiguration(new MarcaOConfiguration());
            builder.ApplyConfiguration(new MecanicoConfiguration());
            builder.ApplyConfiguration(new RegistroConfiguration());
            builder.ApplyConfiguration(new TipoManutencaoConfiguration());
            builder.ApplyConfiguration(new TipoPecasConfiguration());
            builder.ApplyConfiguration(new VeiculoConfiguration());

            base.OnModelCreating(builder);

        }
    }
}
