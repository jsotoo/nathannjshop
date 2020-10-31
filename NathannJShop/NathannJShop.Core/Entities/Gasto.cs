using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class Gasto
    {
        public int GastoId { get; set; }
        public int Total { get; set; }

        public IList<GastoProducto> GastosProductos { get; set; }
    }
}
