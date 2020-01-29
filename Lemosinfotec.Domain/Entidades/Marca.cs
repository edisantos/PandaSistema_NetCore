using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        public ICollection<Veiculo> Veiculo {get;set;}
       
    }
}