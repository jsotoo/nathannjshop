﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NathannJShop.Infraestructure.Data;

namespace NathannJShop.Infraestructure.Migrations
{
    [DbContext(typeof(NathannJShopContext))]
    [Migration("20200715050952_EighthMigration")]
    partial class EighthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NathannJShop.Core.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Devolucion", b =>
                {
                    b.Property<int>("DevolucionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Queja")
                        .HasColumnType("int");

                    b.HasKey("DevolucionId");

                    b.ToTable("Devoluciones");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.DevolucionProducto", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("DevolucionId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId", "DevolucionId");

                    b.HasIndex("DevolucionId");

                    b.ToTable("DevolucionesXProductos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.EstadoSolicitud", b =>
                {
                    b.Property<int>("EstadoSolicitudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SolicitudId")
                        .HasColumnType("int");

                    b.HasKey("EstadoSolicitudId");

                    b.HasIndex("SolicitudId")
                        .IsUnique();

                    b.ToTable("EstadosSolicitudes");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Gasto", b =>
                {
                    b.Property<int>("GastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("GastoId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.GastoProducto", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("GastoId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId", "GastoId");

                    b.HasIndex("GastoId");

                    b.ToTable("GastosXProductos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("PromocionId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PromocionId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Promocion", b =>
                {
                    b.Property<int>("PromocionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activa")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PromocionId");

                    b.ToTable("Promociones");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Solicitud", b =>
                {
                    b.Property<int>("SolicitudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRespuesta")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitudTipoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("SolicitudId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("SolicitudTipoId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.SolicitudTipo", b =>
                {
                    b.Property<int>("SolicitudTipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SolicitudTipoId");

                    b.ToTable("SolicitudesTipos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalVenta")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.VentaProducto", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.Property<int?>("DevolucionId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId", "VentaId");

                    b.HasIndex("DevolucionId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasXProductos");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.DevolucionProducto", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Devolucion", "Devolucion")
                        .WithMany()
                        .HasForeignKey("DevolucionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NathannJShop.Core.Entities.Producto", "Producto")
                        .WithMany("DevolucionesProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.EstadoSolicitud", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Solicitud", "Solicitud")
                        .WithOne("EstadoSolicitud")
                        .HasForeignKey("NathannJShop.Core.Entities.EstadoSolicitud", "SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.GastoProducto", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Gasto", "Gasto")
                        .WithMany("GastosProductos")
                        .HasForeignKey("GastoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NathannJShop.Core.Entities.Producto", "Producto")
                        .WithMany("GastosProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Producto", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NathannJShop.Core.Entities.Promocion", "Promocion")
                        .WithMany("Productos")
                        .HasForeignKey("PromocionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.Solicitud", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Producto", "Producto")
                        .WithMany("Solicitudes")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NathannJShop.Core.Entities.SolicitudTipo", "SolicitudTipo")
                        .WithMany("Solicitudes")
                        .HasForeignKey("SolicitudTipoId");
                });

            modelBuilder.Entity("NathannJShop.Core.Entities.VentaProducto", b =>
                {
                    b.HasOne("NathannJShop.Core.Entities.Devolucion", null)
                        .WithMany("VentasProductos")
                        .HasForeignKey("DevolucionId");

                    b.HasOne("NathannJShop.Core.Entities.Producto", "Producto")
                        .WithMany("VentasProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NathannJShop.Core.Entities.Venta", "Venta")
                        .WithMany("VentasProductos")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
