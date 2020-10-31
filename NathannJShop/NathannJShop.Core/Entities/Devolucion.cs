using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class Devolucion
    {
        public int DevolucionId { get; set; }
        public int Queja { get; set; }
        public IList<DevolucionProducto> VentasProductos { get; set; }
    }
}
