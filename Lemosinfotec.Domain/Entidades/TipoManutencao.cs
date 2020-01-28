using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class TipoManutencao
    {
        public int TipoManuId { get; set; }
        public string Nome { get; set; }

        public ICollection<Registro> Registro {get;set;}
       
    }
}