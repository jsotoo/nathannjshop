using NathannJShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Contracts.V1.Requests
{
    public class CreateProductoRequest
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int? Categoria { get; set; }
        public int? Promocion { get; set; }
        public double Precio { get; set; }
    }
}
