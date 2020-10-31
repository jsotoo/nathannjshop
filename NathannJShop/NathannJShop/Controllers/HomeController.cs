using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NathannJShop.Contracts.V1.Responses;
using NathannJShop.Controllers.V1;
using NathannJShop.Core.Entities;
using NathannJShop.Core.Interfaces;
using NathannJShop.Infraestructure.Repositories;
using NathannJShop.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NathannJShop.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ProductoRepository _productoRepository;
        private readonly CategoriaRepository _categoriaRepository;
        private readonly PromocionRepository _promocionRepository;




        public HomeController(ProductoRepository productoRepository, CategoriaRepository categoriaRepository, PromocionRepository promocionRepository)
        {
            _productoRepository = productoRepository;
            _categoriaRepository = categoriaRepository;
            _promocionRepository = promocionRepository;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Promotions()
        {
            return View();
        }


        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Products()
        {
            var producto = new ProductoViewModel
            {

                Categorias = await _categoriaRepository.GetAll(),
                Promociones = await _promocionRepository.GetAll(),
                Mensaje = ""
            };

            return View(producto);
        }


        /*Consumo del POST*/

        [HttpPost]
        public async Task<IActionResult> Products(ProductoViewModel product)
        {

            var producto = new ProductoViewModel
            {

                Categorias = await _categoriaRepository.GetAll(),
                Promociones = await _promocionRepository.GetAll(),
                Mensaje = ViewBag.Message
            };


            if (ModelState.IsValid)
            {

                var prod = new ProductoResponse
                {
                    Nombre = product.Producto.Nombre,
                    Marca = product.Producto.Marca,
                    Precio = product.Producto.Precio,
                    Descripcion = product.Producto.Descripcion,
                    Categoria = product.Producto.CategoriaId,
                    Promocion = product.Producto.PromocionId

                };


                var httpClient = new HttpClient();
                string ruta = "https://nathannjshop.azurewebsites.net/api/v1/productos";
                var stringContent = new StringContent(JsonConvert.SerializeObject(prod), Encoding.UTF8, "application/json");

                var resultapiResult = await httpClient.PostAsync(ruta, stringContent);
                string resultContent = resultapiResult.Content.ReadAsStringAsync().Result;


                if (resultContent == null)
                {
                    ViewBag.Message = "No se ha registrado ";
                    ViewBag.alert = "danger";
                }
                else
                {
                    ViewBag.Message = "Se ha registrado correctamente";
                    ViewBag.alert = "success";
                }


                return View(producto);

            }

            return View(producto);

        }



      
        /*Consumo del GET*/
        public async Task<IActionResult> ShowProducts()
        {
            var httpClient = new HttpClient();
            string ruta = "https://nathannjshop.azurewebsites.net/api/v1/productos";
            string resultapiResult = await httpClient.GetStringAsync(ruta);
            List<ProductoResponse> result = JsonConvert.DeserializeObject<List<ProductoResponse>>(resultapiResult);

            ProductoViewModel producto = new ProductoViewModel
            {
                ListProductsCustom = _productoRepository.GetAllCustom().ToList(),
                Categorias = await _categoriaRepository.GetAll(),
                Promociones = await _promocionRepository.GetAll(),
            };


            ViewBag.Products = result;
            return View(producto);


        }


        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductoViewModel productoUpdt)
        {

            var prod = new Producto
            {
                ProductoId = productoUpdt.Producto.ProductoId,
                Nombre = productoUpdt.Producto.Nombre,
                Marca = productoUpdt.Producto.Marca,
                Precio = productoUpdt.Producto.Precio,
                Descripcion = productoUpdt.Producto.Descripcion,
                CategoriaId = productoUpdt.Producto.CategoriaId,
                PromocionId = productoUpdt.Producto.PromocionId
            };



            //var httpClient = new HttpClient();
            //string ruta = "https://localhost:44341/api/v1/productos";
            //var stringContent = new StringContent(JsonConvert.SerializeObject(prod), Encoding.UTF8, "application/json");

            //var resultapiResult = await httpClient.PutAsync(ruta, stringContent);
            //string resultContent = resultapiResult.Content.ReadAsStringAsync().Result;

            var producto = await _productoRepository.Get(productoUpdt.Producto.ProductoId);

            producto.Nombre = productoUpdt.Producto.Nombre;
            producto.Marca = productoUpdt.Producto.Marca;
            producto.Precio = productoUpdt.Producto.Precio;
            producto.Descripcion = productoUpdt.Producto.Descripcion;
            producto.CategoriaId = productoUpdt.Producto.CategoriaId;
            producto.PromocionId = productoUpdt.Producto.PromocionId;

            var postUpdated = await _productoRepository.Update(producto);

            if (postUpdated != null)
            {
                ViewBag.actualizado = "Se ha actualizado el registro";
            }
            else
            {
                ViewBag.actualizado = "No se ha actuazliado";
            }



            return RedirectToAction(nameof(UpdateProduct), "Home");

        }


        [HttpPost]

        public async Task<IActionResult> DeleteProduct(ProductoViewModel productoUpdt)
        {


            var httpClient = new HttpClient();
            string ruta = "https://nathannjshop.azurewebsites.net/api/v1/productos/" + productoUpdt.Producto.ProductoId;

            var resultapiResult = await httpClient.DeleteAsync(ruta);
            string resultContent = resultapiResult.Content.ReadAsStringAsync().Result;

            //Producto update = await _productoRepository.Update(prod, prod.ProductoId);

            if (resultContent != null)
            {
                ViewBag.eliminado = "Se ha eliminado el registro";
            }
            else
            {
                ViewBag.eliminado = "No se ha eliminado actuazliado";
            }



            return RedirectToAction(nameof(ShowProducts), "Home");


        }






    }
}
