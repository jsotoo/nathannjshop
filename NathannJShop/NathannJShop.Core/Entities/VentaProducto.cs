using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class VentaProducto
    {
        public int VentaId { get; set; }
        public Venta  Venta { get; set; } 
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
