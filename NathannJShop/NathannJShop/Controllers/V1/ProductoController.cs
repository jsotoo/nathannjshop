using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NathannJShop.Contracts.V1;
using NathannJShop.Contracts.V1.Requests;
using NathannJShop.Contracts.V1.Responses;
using NathannJShop.Core.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using NathannJShop.Infraestructure.Repositories;


namespace NathannJShop.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductoController : Controller
    {
        private readonly ProductoRepository _productoRepository;
        private readonly CategoriaRepository _categoriaRepository;
        private readonly PromocionRepository _promocionRepository;


        public ProductoController(ProductoRepository productoRepository, CategoriaRepository categoriaRepository, PromocionRepository promocionRepository )
        {
            _productoRepository = productoRepository;
            _categoriaRepository = categoriaRepository;
            _promocionRepository = promocionRepository;
        }

        [HttpGet(ApiRoutes.Productos.GetAll)]

        public async Task<IActionResult> GetAll()
        {
            var productos = from Produc in  await _productoRepository.GetAll()
                            join Categ in await _categoriaRepository.GetAll() 
                            on Produc.CategoriaId equals Categ.CategoriaId
                            join Prom in await _promocionRepository.GetAll() on Produc.PromocionId equals Prom.PromocionId
                            select new ProductoResponse
                            {
                                ProductoId = Produc.ProductoId,
                                Nombre = Produc.Nombre,
                                Descripcion = Produc.Descripcion,
                                Marca = Produc.Marca,
                                Categoria = Categ.CategoriaId,
                                Promocion = Prom.PromocionId,
                                Precio = Produc.Precio

                            };
            return Ok(productos);

        }

        [HttpGet(ApiRoutes.Productos.Get)]
        public async Task<IActionResult> Get([FromRoute] int productoId)
        {

            var producto = from Produc in await _productoRepository.GetAll()
                            join Categ in await _categoriaRepository.GetAll()
                            on Produc.CategoriaId equals Categ.CategoriaId
                            join Prom in await _promocionRepository.GetAll() on Produc.PromocionId equals Prom.PromocionId
                            where Produc.ProductoId == productoId
                            select new ProductoResponse
                            {
                                ProductoId = Produc.ProductoId,
                                Nombre = Produc.Nombre,
                                Descripcion = Produc.Descripcion,
                                Marca = Produc.Marca,
                                Categoria = Categ.CategoriaId,
                                Promocion = Prom.PromocionId,
                                Precio = Produc.Precio

                            };



            if (producto == null) return NotFound();

            return Ok(producto);
        }

        [HttpPost(ApiRoutes.Productos.Create)]

        public async Task<IActionResult> Create([FromBody] CreateProductoRequest productoRequest)
        {
            var newProducto = new Producto
            {
                Nombre = productoRequest.Nombre,
                Descripcion = productoRequest.Descripcion,
                Marca = productoRequest.Marca,
                CategoriaId = productoRequest.Categoria,
                PromocionId = productoRequest.Promocion,
                Precio = productoRequest.Precio
            };

            Producto result = await _productoRepository.Add(newProducto);

            if (result == null) return BadRequest();

            var response = new ProductoResponse
            {
                ProductoId =result.ProductoId,
                Nombre = result.Nombre,
                Descripcion = result.Descripcion,
                Marca = result.Marca,
                Categoria = result.CategoriaId,
                Promocion = result.PromocionId,
                Precio = result.Precio
            };

            string urlBase = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            string locationUri = $"{urlBase}/{ApiRoutes.Productos.Get.Replace("{productoId}", response.ProductoId.ToString())}";
            return Created(locationUri, response);
        }

        [HttpPut(ApiRoutes.Productos.Update)]
        public async Task<IActionResult> Update([FromRoute] int productoId, [FromBody] UpdateProductoRequest productoRequest)
        {
       
            var producto = await _productoRepository.Get(productoId);

            producto.Nombre = productoRequest.Nombre;
            producto.Descripcion = productoRequest.Descripcion;
            producto.Marca = productoRequest.Marca;
            producto.CategoriaId = productoRequest.Categoria;
            producto.PromocionId = productoRequest.Promocion;
            producto.Precio = productoRequest.Precio;



            var productoUpdated = await _productoRepository.Update(producto);

            if (productoUpdated != null) return Ok(producto);
            return BadRequest();
        }

        [HttpDelete(ApiRoutes.Productos.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int productoId)
        {

            var productoDeleted = await _productoRepository.Delete(productoId);


            if (productoDeleted != null) return Ok();
            return BadRequest();
        }




    }
}
