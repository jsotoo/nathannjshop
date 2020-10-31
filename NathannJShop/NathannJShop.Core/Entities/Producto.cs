using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Core.Entities
{
    public class Producto
    {

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es requerido.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La categoria del producto es requerida.")]
        public int? CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "La marca del producto es requerida.")]
        public string Marca { get; set; }
        public Promocion Promocion { get; set; }

        [Required(ErrorMessage = "La promocion del producto es requerida.")]
        public int? PromocionId { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerida.")]
        public double Precio { get; set; }

        public IEnumerable<Solicitud> Solicitudes { get; set; }

        public IList<VentaProducto> VentasProductos { get; set; }

        public IList<DevolucionProducto> DevolucionesProductos { get; set; }

        public IList<GastoProducto> GastosProductos { get; set; }


    }
}
