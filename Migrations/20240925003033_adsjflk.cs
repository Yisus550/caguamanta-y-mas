using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace caguamanta_y_mas.Migrations
{
    /// <inheritdoc />
    public partial class adsjflk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomC = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    idC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    importancia = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idC);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    idH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    turno = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    HoraEnt = table.Column<TimeOnly>(type: "time", nullable: true),
                    Horasal = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.idH);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    idM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomM = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Cant = table.Column<int>(type: "int", nullable: true),
                    Proveedor = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    costo = table.Column<decimal>(type: "money", nullable: true),
                    UnidadMedida = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    fechaCad = table.Column<DateOnly>(type: "date", nullable: true),
                    idCate = table.Column<int>(type: "int", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.idM);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    idProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePv = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ApellidoPv = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Lada = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    Correo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Empresa = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    recurso = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.idProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    idPue = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Sueldo = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.idPue);
                });

            migrationBuilder.CreateTable(
                name: "Platillos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomP = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Categoria = table.Column<int>(type: "int", nullable: true),
                    PrecioUnidad = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platillos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Platillos_Categoria_Categoria",
                        column: x => x.Categoria,
                        principalTable: "Categoria",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    idPuesto = table.Column<int>(type: "int", nullable: true),
                    FhNa = table.Column<DateOnly>(type: "date", nullable: true),
                    FhCon = table.Column<DateOnly>(type: "date", nullable: true),
                    Dir = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    Tel = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Correo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    idTurno = table.Column<int>(type: "int", nullable: true),
                    usuario = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    contraseña = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idU);
                    table.ForeignKey(
                        name: "FK_Usuarios_Puestos_idPuesto",
                        column: x => x.idPuesto,
                        principalTable: "Puestos",
                        principalColumn: "idPue");
                    table.ForeignKey(
                        name: "FK_Usuarios_horarios_idTurno",
                        column: x => x.idTurno,
                        principalTable: "horarios",
                        principalColumn: "idH");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    idCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateOnly>(type: "date", nullable: false),
                    IDEmpleado = table.Column<int>(type: "int", nullable: false),
                    IDProveedor = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.idCompra);
                    table.ForeignKey(
                        name: "FK_Compra_Proveedores_IDProveedor",
                        column: x => x.IDProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "idProveedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_Usuarios_IDEmpleado",
                        column: x => x.IDEmpleado,
                        principalTable: "Usuarios",
                        principalColumn: "idU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateOnly>(type: "date", nullable: false),
                    IDEmpleado = table.Column<int>(type: "int", nullable: false),
                    IDCliente = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_Venta_Clientes_IDCliente",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "idC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Usuarios_IDEmpleado",
                        column: x => x.IDEmpleado,
                        principalTable: "Usuarios",
                        principalColumn: "idU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompras",
                columns: table => new
                {
                    IDCompra = table.Column<int>(type: "int", nullable: false),
                    IDProducto = table.Column<int>(type: "int", nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "money", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DetalleCompras_Compra_IDCompra",
                        column: x => x.IDCompra,
                        principalTable: "Compra",
                        principalColumn: "idCompra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCompras_Material_IDProducto",
                        column: x => x.IDProducto,
                        principalTable: "Material",
                        principalColumn: "idM",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentas",
                columns: table => new
                {
                    IDVenta = table.Column<int>(type: "int", nullable: false),
                    IDProducto = table.Column<int>(type: "int", nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "money", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Importe = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Platillos_IDProducto",
                        column: x => x.IDProducto,
                        principalTable: "Platillos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Venta_IDVenta",
                        column: x => x.IDVenta,
                        principalTable: "Venta",
                        principalColumn: "idVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IDEmpleado",
                table: "Compra",
                column: "IDEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IDProveedor",
                table: "Compra",
                column: "IDProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompras_IDCompra",
                table: "DetalleCompras",
                column: "IDCompra");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompras_IDProducto",
                table: "DetalleCompras",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_IDProducto",
                table: "DetalleVentas",
                column: "IDProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_IDVenta",
                table: "DetalleVentas",
                column: "IDVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Platillos_Categoria",
                table: "Platillos",
                column: "Categoria");

            migrationBuilder.CreateIndex(
                name: "UQ__Proveedo__4EC504804A961C80",
                table: "Proveedores",
                column: "Telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Proveedo__60695A19F78EA2F7",
                table: "Proveedores",
                column: "Correo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Puestos__75E3EFCF22BEF3D4",
                table: "Puestos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_idPuesto",
                table: "Usuarios",
                column: "idPuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_idTurno",
                table: "Usuarios",
                column: "idTurno");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuarios__60695A192D3A4610",
                table: "Usuarios",
                column: "Correo",
                unique: true,
                filter: "[Correo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuarios__9AFF8FC6E1B486FF",
                table: "Usuarios",
                column: "usuario",
                unique: true,
                filter: "[usuario] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuarios__C031220B5B7F827D",
                table: "Usuarios",
                column: "Dir",
                unique: true,
                filter: "[Dir] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuarios__C451FA8DFC154154",
                table: "Usuarios",
                column: "Tel",
                unique: true,
                filter: "[Tel] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IDCliente",
                table: "Venta",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IDEmpleado",
                table: "Venta",
                column: "IDEmpleado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCompras");

            migrationBuilder.DropTable(
                name: "DetalleVentas");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Platillos");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "horarios");
        }
    }
}
