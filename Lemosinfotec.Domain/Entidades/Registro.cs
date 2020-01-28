using System;
using System.Collections.Generic;

namespace Lemosinfotec.Domain.Entidades
{
    public class Registro
    {
      public int id { get; set; }
      public DateTime Data { get; set; }
      public int ClienteId { get; set; }
      public int TipoManutencaoId { get; set; } 
      public int MecanicoId { get; set; }
      public int TipoPecaId { get; set; }
      public decimal Valor { get; set; }
      public string Descricao { get; set; }

     /*Refencia para relacionamento entre tabelas*/
      
      public virtual Cliente Cliente { get; set; }
      public virtual TipoManutencao TipoManutencao{get;set;}
      public virtual TipoPeca TipoPeca {get;set;}
      public virtual Mecanico Mecanico{get;set;}
     
    }
}
