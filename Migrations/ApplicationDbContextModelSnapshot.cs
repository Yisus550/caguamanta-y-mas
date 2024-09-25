﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using caguamanta_y_mas.Datos;

#nullable disable

namespace caguamanta_y_mas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("caguamanta_y_mas.Models.Categorium", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("NomC")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Cliente", b =>
                {
                    b.Property<int>("idC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idC"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("importancia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idC");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Compra", b =>
                {
                    b.Property<int>("idCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCompra"));

                    b.Property<DateOnly>("FechaCompra")
                        .HasColumnType("date");

                    b.Property<int>("IDEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IDProveedor")
                        .HasColumnType("int");

                    b.Property<double?>("Importe")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("idCompra");

                    b.HasIndex("IDEmpleado");

                    b.HasIndex("IDProveedor");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.DetalleCompra", b =>
                {
                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IDCompra")
                        .HasColumnType("int");

                    b.Property<int>("IDProducto")
                        .HasColumnType("int");

                    b.Property<double?>("Importe")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double>("PrecioUnidad")
                        .HasColumnType("float");

                    b.HasIndex("IDCompra");

                    b.HasIndex("IDProducto");

                    b.ToTable("DetalleCompras");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.DetalleVenta", b =>
                {
                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IDProducto")
                        .HasColumnType("int");

                    b.Property<int>("IDVenta")
                        .HasColumnType("int");

                    b.Property<double?>("Importe")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double>("PrecioUnidad")
                        .HasColumnType("float");

                    b.HasIndex("IDProducto");

                    b.HasIndex("IDVenta");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Material", b =>
                {
                    b.Property<int>("idM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idM"));

                    b.Property<int?>("Cant")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NomM")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double?>("costo")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateOnly?>("fechaCad")
                        .HasColumnType("date");

                    b.Property<int?>("idCate")
                        .HasColumnType("int");

                    b.Property<int?>("stock")
                        .HasColumnType("int");

                    b.HasKey("idM");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Platillo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Categoria")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("NomP")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double?>("PrecioUnidad")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Categoria");

                    b.ToTable("Platillos");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Proveedore", b =>
                {
                    b.Property<int>("idProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProveedor"));

                    b.Property<string>("ApellidoPv")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Lada")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("NombrePv")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("recurso")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("idProveedor");

                    b.HasIndex(new[] { "Telefono" }, "UQ__Proveedo__4EC504804A961C80")
                        .IsUnique();

                    b.HasIndex(new[] { "Correo" }, "UQ__Proveedo__60695A19F78EA2F7")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Puesto", b =>
                {
                    b.Property<int>("idPue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPue"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double?>("Sueldo")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("idPue");

                    b.HasIndex(new[] { "Nombre" }, "UQ__Puestos__75E3EFCF22BEF3D4")
                        .IsUnique();

                    b.ToTable("Puestos");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Usuario", b =>
                {
                    b.Property<int>("idU")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idU"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Dir")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateOnly?>("FhCon")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FhNa")
                        .HasColumnType("date");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("idPuesto")
                        .HasColumnType("int");

                    b.Property<int?>("idTurno")
                        .HasColumnType("int");

                    b.Property<string>("usuario1")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("idU");

                    b.HasIndex("idPuesto");

                    b.HasIndex("idTurno");

                    b.HasIndex(new[] { "Correo" }, "UQ__Usuarios__60695A192D3A4610")
                        .IsUnique()
                        .HasFilter("[Correo] IS NOT NULL");

                    b.HasIndex(new[] { "usuario1" }, "UQ__Usuarios__9AFF8FC6E1B486FF")
                        .IsUnique();

                    b.HasIndex(new[] { "Dir" }, "UQ__Usuarios__C031220B5B7F827D")
                        .IsUnique();

                    b.HasIndex(new[] { "Tel" }, "UQ__Usuarios__C451FA8DFC154154")
                        .IsUnique()
                        .HasFilter("[Tel] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Ventum", b =>
                {
                    b.Property<int>("idVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVenta"));

                    b.Property<DateOnly>("FechaVenta")
                        .HasColumnType("date");

                    b.Property<int>("IDCliente")
                        .HasColumnType("int");

                    b.Property<int>("IDEmpleado")
                        .HasColumnType("int");

                    b.Property<double?>("Importe")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("idVenta");

                    b.HasIndex("IDCliente");

                    b.HasIndex("IDEmpleado");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.horario", b =>
                {
                    b.Property<int>("idH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idH"));

                    b.Property<TimeOnly?>("HoraEnt")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("Horasal")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<string>("turno")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("idH");

                    b.ToTable("horarios");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Compra", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Usuario", "IDEmpleadoNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IDEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("caguamanta_y_mas.Models.Proveedore", "IDProveedorNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IDProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDEmpleadoNavigation");

                    b.Navigation("IDProveedorNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.DetalleCompra", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Compra", "IDCompraNavigation")
                        .WithMany()
                        .HasForeignKey("IDCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("caguamanta_y_mas.Models.Material", "IDProductoNavigation")
                        .WithMany()
                        .HasForeignKey("IDProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDCompraNavigation");

                    b.Navigation("IDProductoNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.DetalleVenta", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Platillo", "IDProductoNavigation")
                        .WithMany()
                        .HasForeignKey("IDProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("caguamanta_y_mas.Models.Ventum", "IDVentaNavigation")
                        .WithMany()
                        .HasForeignKey("IDVenta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDProductoNavigation");

                    b.Navigation("IDVentaNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Platillo", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Categorium", "CategoriaNavigation")
                        .WithMany("Platillos")
                        .HasForeignKey("Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Usuario", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Puesto", "idPuestoNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("idPuesto");

                    b.HasOne("caguamanta_y_mas.Models.horario", "idTurnoNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("idTurno");

                    b.Navigation("idPuestoNavigation");

                    b.Navigation("idTurnoNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Ventum", b =>
                {
                    b.HasOne("caguamanta_y_mas.Models.Cliente", "IDClienteNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IDCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("caguamanta_y_mas.Models.Usuario", "IDEmpleadoNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IDEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDClienteNavigation");

                    b.Navigation("IDEmpleadoNavigation");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Categorium", b =>
                {
                    b.Navigation("Platillos");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Cliente", b =>
                {
                    b.Navigation("Venta");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Proveedore", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Puesto", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.Usuario", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("caguamanta_y_mas.Models.horario", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
