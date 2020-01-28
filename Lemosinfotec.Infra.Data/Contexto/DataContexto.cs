using Lemosinfotec.Domain.Entidades;
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
        public DbSet<TipoManutencao> TipoManutencaos{get;set;}
        public DbSet<TipoPeca> TipoPecas{get;set;}
        public DbSet<Fornecedor> Fornecedores{get;set;}
        public DbSet<Estoque> Estoques{get;set;}

        //Fim Entidades

        /*Metodo Conexao EntityFrameworkCore*/
        public DataContexto( DbContextOptions<DataContexto> options) : base(options)
        {
        }
    }
}
