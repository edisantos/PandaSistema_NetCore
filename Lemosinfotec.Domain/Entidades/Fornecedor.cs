using System;
using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public ICollection<TipoPeca> TipoPeca{get;set;}
        public ICollection<Estoque> Estoque{get;set;}
        
    }
}