using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class DevolucionProducto
    {
        public int DevolucionId { get; set; }
        public Devolucion Devolucion { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
