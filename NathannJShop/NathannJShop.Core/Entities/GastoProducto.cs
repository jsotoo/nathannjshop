using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class GastoProducto
    {
        public int GastoId { get; set; }
        public Gasto Gasto { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
