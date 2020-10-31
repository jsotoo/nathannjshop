using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NathannJShop.Core.Entities;

namespace NathannJShop.Infraestructure.Data
{
    public class NathannJShopContext : IdentityDbContext
    {
        public NathannJShopContext(DbContextOptions<NathannJShopContext> options)
        : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Promocion> Promociones { get; set; }

        public DbSet<Solicitud> Solicitudes { get; set; }

        public DbSet<SolicitudTipo> SolicitudesTipos { get; set; }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<EstadoSolicitud> EstadosSolicitudes { get; set; }

        public DbSet<VentaProducto> VentasXProductos { get; set; }

        public DbSet<Devolucion> Devoluciones { get; set; }

        public DbSet<DevolucionProducto> DevolucionesXProductos { get; set; }

        public DbSet<Gasto> Gastos { get; set; }

        public DbSet<GastoProducto> GastosXProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VentaProducto>().HasKey(et => new { et.ProductoId, et.VentaId });
            modelBuilder.Entity<DevolucionProducto>().HasKey(et => new { et.ProductoId, et.DevolucionId });
            modelBuilder.Entity<GastoProducto>().HasKey(et => new { et.ProductoId, et.GastoId });
        }




    }
}
    

