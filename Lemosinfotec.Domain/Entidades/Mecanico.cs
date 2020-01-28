using System;
using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class Mecanico
    {
        public int MecanicoId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }

        public ICollection<Registro> Registro{get;set;}
    }
}