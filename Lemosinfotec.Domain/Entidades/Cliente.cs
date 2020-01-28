using System;
using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int VeiculoId { get; set; }
        public string Placa { get; set; }

        public virtual Veiculo Veiculo { get; set; }
        public ICollection<Registro> Registro { get; set; }
        

    }
}