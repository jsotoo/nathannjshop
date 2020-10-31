using NathannJShop.Core.Entities;
using System.Collections.Generic;

namespace NathannJShop.ViewModels
{
    public class ProductoViewModel
    {
        public Producto Producto { get; set; }

        public IList<Categoria> Categorias { get; set; }

        public IList<Promocion> Promociones { get; set; }
        public string Mensaje { get; set; }

        public IList<Producto> Productos { get; set; }

        public IList<Producto> ListProductsCustom { get; set; }






    }
}
