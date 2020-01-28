using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class TipoPeca
    {
        public int TipoPecaId { get; set; }
        public string Nome { get; set; }

        public int FornecedorId { get; set; }

        public ICollection<Registro> Registro{get;set;}
        public ICollection<Estoque> Estoques{get;set;}
        public virtual Fornecedor Fornecedores{get;set;}
    }
}