using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lemosinfotec.Infra.Data.Contexto
{
    public class Factory : IDesignTimeDbContextFactory<DataContexto>
    {
        public DataContexto CreateDbContext(string[] args)
        {
           var optionBuilder = new DbContextOptionsBuilder<DataContexto>();
           optionBuilder.UseMySql("Server=localhost;DataBase=PandaSystem;Uid=root;Pwd=info@1234");
           return new DataContexto(optionBuilder.Options);
        }
    }
}
