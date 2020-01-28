using System;

namespace Lemosinfotec.Domain.Entidades
{
    public class Estoque
    {
        public int EstoqueId{get;set;}
        public int TipoPecaId { get; set; }
        public int FornecedorId{get;set;}

        public DateTime Data{get;set;}
        public int Quantidade{get;set;}

       public virtual TipoPeca TipoPeca{get;set;}
       public virtual Fornecedor Fornecedore{get;set;}
    }
}