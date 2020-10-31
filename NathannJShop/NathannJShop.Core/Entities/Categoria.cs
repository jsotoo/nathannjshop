using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Core.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Producto> Productos { get; set; }
    }
}
