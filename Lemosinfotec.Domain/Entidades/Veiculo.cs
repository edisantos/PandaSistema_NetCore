using System.Collections.Generic;
namespace Lemosinfotec.Domain.Entidades
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Nome { get; set; }
        public int MarcaId { get; set; }
        public virtual Marca Marca {get;set;}
        public ICollection<Cliente> Cliente{get;set;}
    }
}