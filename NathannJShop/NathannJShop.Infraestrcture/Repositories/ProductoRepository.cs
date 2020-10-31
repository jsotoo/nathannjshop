using Microsoft.EntityFrameworkCore.Query;
using NathannJShop.Core.Entities;
using NathannJShop.Core.Interfaces;
using NathannJShop.Infraestructure.Data;
using NathannJShop.Infraestructure.Repositories.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NathannJShop.Infraestructure.Repositories
{
    public class ProductoRepository : EfCoreRepository<Producto, NathannJShopContext>
    {
        private readonly NathannJShopContext _context;

    
        public ProductoRepository(NathannJShopContext context) : base(context)
        {
            _context = context;
        }
     
        public IEnumerable<Producto> GetAllCustom()
        {
            List<Producto> productos = new List<Producto>();
            var query = (from producto in _context.Productos

                         select new
                         {
                             Id = producto.ProductoId,
                             Producto = producto.Nombre,
                             Descripcion = producto.Descripcion,
                             Marca = producto.Marca,
                             Categoria = producto.Categoria.Nombre,
                             Promocion = producto.Promocion.Nombre,
                             Precio = producto.Precio

                         }).ToList();


            foreach (var item in query)
            {
                productos.Add(new Producto
                {
                    ProductoId = item.Id,
                    Nombre = item.Producto,
                    Descripcion = item.Descripcion,
                    Marca = item.Marca,
                    Categoria = new Categoria() { Nombre = item.Categoria },
                    Promocion = new Promocion() { Nombre = item.Promocion },
                    Precio = item.Precio


                });

            }

            return productos.ToList();
        }












    }
}
