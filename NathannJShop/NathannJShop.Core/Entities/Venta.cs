using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class Venta 
    {
        public int VentaId { get; set; } 
        public DateTime FechaVenta { get; set; }
        public int TotalVenta { get; set; }
        public IList<VentaProducto> VentasProductos { get; set; }

        public string UserId { get; set; }


    }
}
