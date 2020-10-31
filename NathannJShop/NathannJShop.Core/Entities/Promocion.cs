using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Core.Entities
{
    public class Promocion
    {
       public int PromocionId { get; set; }
        public string Nombre { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        public IEnumerable<Producto> Productos { get; set; }

    }
}
