using NathannJShop.Core.Entities;
using System.Collections.Generic;

namespace NathannJShop.ViewModels
{
    public class ProductosViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Promocion { get; set; }
        public double Precio { get; set; }
    }
}
