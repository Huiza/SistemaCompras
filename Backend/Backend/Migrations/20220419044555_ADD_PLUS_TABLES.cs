using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class ADD_PLUS_TABLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosid",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Empresa_empresasnit",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_perfilid",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaid",
                table: "Empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.DropIndex(
                name: "IX_AgendaTelefonica_contactosid",
                table: "AgendaTelefonica");

            migrationBuilder.DropIndex(
                name: "IX_AgendaTelefonica_empresasnit",
                table: "AgendaTelefonica");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "contactosid",
                table: "AgendaTelefonica");

            migrationBuilder.DropColumn(
                name: "empresasnit",
                table: "AgendaTelefonica");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TipoEmpresa",
                newName: "id_tipo_empresa");

            migrationBuilder.RenameColumn(
                name: "razonSocial",
                table: "Perfil",
                newName: "razon_social");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Perfil",
                newName: "id_perfil");

            migrationBuilder.RenameColumn(
                name: "tipoEmpresaid",
                table: "Empresa",
                newName: "id_tipo_empresa1");

            migrationBuilder.RenameColumn(
                name: "representante",
                table: "Empresa",
                newName: "nombre_representante");

            migrationBuilder.RenameColumn(
                name: "perfilid",
                table: "Empresa",
                newName: "id_perfil1");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_tipoEmpresaid",
                table: "Empresa",
                newName: "IX_Empresa_id_tipo_empresa1");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_perfilid",
                table: "Empresa",
                newName: "IX_Empresa_id_perfil1");

            migrationBuilder.RenameColumn(
                name: "idEmpresa",
                table: "AgendaTelefonica",
                newName: "nit");

            migrationBuilder.RenameColumn(
                name: "idContacto",
                table: "AgendaTelefonica",
                newName: "id_contacto");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AgendaTelefonica",
                newName: "id_agenda");

            migrationBuilder.AlterColumn<string>(
                name: "nit",
                table: "Empresa",
                type: "varchar=17",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id_contacto",
                table: "Contacto",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "contactoid_contacto",
                table: "AgendaTelefonica",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "empresanit",
                table: "AgendaTelefonica",
                type: "varchar=17",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "id_contacto");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id_categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id_categoria);
                });

            migrationBuilder.CreateTable(
                name: "Criterio",
                columns: table => new
                {
                    id_criterio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterio", x => x.id_criterio);
                });

            migrationBuilder.CreateTable(
                name: "DescuentoComercial",
                columns: table => new
                {
                    id_descuento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescuentoComercial", x => x.id_descuento);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    id_pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.id_pago);
                });

            migrationBuilder.CreateTable(
                name: "PlazoPago",
                columns: table => new
                {
                    id_pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    periodo = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlazoPago", x => x.id_pago);
                });

            migrationBuilder.CreateTable(
                name: "Requisicion",
                columns: table => new
                {
                    id_detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prioridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_estimada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicion", x => x.id_detalle);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id_rol);
                });

            migrationBuilder.CreateTable(
                name: "TipoProducto",
                columns: table => new
                {
                    id_tipo_producto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProducto", x => x.id_tipo_producto);
                });

            migrationBuilder.CreateTable(
                name: "Evaluacion",
                columns: table => new
                {
                    id_evaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_criterio = table.Column<int>(type: "int", nullable: false),
                    nit = table.Column<int>(type: "int", nullable: false),
                    nota = table.Column<int>(type: "int", nullable: false),
                    criterioid_criterio = table.Column<int>(type: "int", nullable: true),
                    empresanit = table.Column<string>(type: "varchar=17", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluacion", x => x.id_evaluacion);
                    table.ForeignKey(
                        name: "FK_Evaluacion_Criterio_criterioid_criterio",
                        column: x => x.criterioid_criterio,
                        principalTable: "Criterio",
                        principalColumn: "id_criterio");
                    table.ForeignKey(
                        name: "FK_Evaluacion_Empresa_empresanit",
                        column: x => x.empresanit,
                        principalTable: "Empresa",
                        principalColumn: "nit");
                });

            migrationBuilder.CreateTable(
                name: "CondicionEconomica",
                columns: table => new
                {
                    id_condicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precio_envases = table.Column<double>(type: "float", nullable: false),
                    precio_embalajes = table.Column<double>(type: "float", nullable: false),
                    pago_transporte = table.Column<double>(type: "float", nullable: false),
                    recargo_aplazamiento = table.Column<double>(type: "float", nullable: false),
                    id_plazoid_pago = table.Column<int>(type: "int", nullable: true),
                    id_descuento1 = table.Column<int>(type: "int", nullable: true),
                    id_pago1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionEconomica", x => x.id_condicion);
                    table.ForeignKey(
                        name: "FK_CondicionEconomica_DescuentoComercial_id_descuento1",
                        column: x => x.id_descuento1,
                        principalTable: "DescuentoComercial",
                        principalColumn: "id_descuento");
                    table.ForeignKey(
                        name: "FK_CondicionEconomica_FormaPago_id_pago1",
                        column: x => x.id_pago1,
                        principalTable: "FormaPago",
                        principalColumn: "id_pago");
                    table.ForeignKey(
                        name: "FK_CondicionEconomica_PlazoPago_id_plazoid_pago",
                        column: x => x.id_plazoid_pago,
                        principalTable: "PlazoPago",
                        principalColumn: "id_pago");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 150, nullable: false),
                    email = table.Column<string>(type: "varchar=150", maxLength: 150, nullable: false),
                    password = table.Column<string>(type: "varchar=150", maxLength: 150, nullable: false),
                    id_rol1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_id_rol1",
                        column: x => x.id_rol1,
                        principalTable: "Rol",
                        principalColumn: "id_rol");
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id_producto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    marca = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    caracteristica = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    medida = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    color = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    utilidad = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    descripcion = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    garantia = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    imagen = table.Column<string>(type: "varchar=150", maxLength: 1, nullable: false),
                    id_tipo_producto1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    id_categoria1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id_producto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_id_categoria1",
                        column: x => x.id_categoria1,
                        principalTable: "Categoria",
                        principalColumn: "id_categoria");
                    table.ForeignKey(
                        name: "FK_Producto_TipoProducto_id_tipo_producto1",
                        column: x => x.id_tipo_producto1,
                        principalTable: "TipoProducto",
                        principalColumn: "id_tipo_producto");
                });

            migrationBuilder.CreateTable(
                name: "DetalleRequisicion",
                columns: table => new
                {
                    id_detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_producto = table.Column<int>(type: "int", nullable: false),
                    id_requisicion = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    productoid_producto = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    usuarioid_usuario = table.Column<int>(type: "int", nullable: true),
                    requisicionid_detalle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleRequisicion", x => x.id_detalle);
                    table.ForeignKey(
                        name: "FK_DetalleRequisicion_Producto_productoid_producto",
                        column: x => x.productoid_producto,
                        principalTable: "Producto",
                        principalColumn: "id_producto");
                    table.ForeignKey(
                        name: "FK_DetalleRequisicion_Requisicion_requisicionid_detalle",
                        column: x => x.requisicionid_detalle,
                        principalTable: "Requisicion",
                        principalColumn: "id_detalle");
                    table.ForeignKey(
                        name: "FK_DetalleRequisicion_Usuario_usuarioid_usuario",
                        column: x => x.usuarioid_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id_usuario");
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion",
                columns: table => new
                {
                    nit = table.Column<string>(type: "varchar=17", maxLength: 17, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    empresanit = table.Column<string>(type: "varchar=17", nullable: true),
                    id_detalle1 = table.Column<int>(type: "int", nullable: true),
                    id_condicion1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion", x => x.nit);
                    table.ForeignKey(
                        name: "FK_Cotizacion_CondicionEconomica_id_condicion1",
                        column: x => x.id_condicion1,
                        principalTable: "CondicionEconomica",
                        principalColumn: "id_condicion");
                    table.ForeignKey(
                        name: "FK_Cotizacion_DetalleRequisicion_id_detalle1",
                        column: x => x.id_detalle1,
                        principalTable: "DetalleRequisicion",
                        principalColumn: "id_detalle");
                    table.ForeignKey(
                        name: "FK_Cotizacion_Empresa_empresanit",
                        column: x => x.empresanit,
                        principalTable: "Empresa",
                        principalColumn: "nit");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_contactoid_contacto",
                table: "AgendaTelefonica",
                column: "contactoid_contacto");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_empresanit",
                table: "AgendaTelefonica",
                column: "empresanit");

            migrationBuilder.CreateIndex(
                name: "IX_CondicionEconomica_id_descuento1",
                table: "CondicionEconomica",
                column: "id_descuento1");

            migrationBuilder.CreateIndex(
                name: "IX_CondicionEconomica_id_pago1",
                table: "CondicionEconomica",
                column: "id_pago1");

            migrationBuilder.CreateIndex(
                name: "IX_CondicionEconomica_id_plazoid_pago",
                table: "CondicionEconomica",
                column: "id_plazoid_pago");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_empresanit",
                table: "Cotizacion",
                column: "empresanit");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_id_condicion1",
                table: "Cotizacion",
                column: "id_condicion1");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_id_detalle1",
                table: "Cotizacion",
                column: "id_detalle1");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRequisicion_productoid_producto",
                table: "DetalleRequisicion",
                column: "productoid_producto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRequisicion_requisicionid_detalle",
                table: "DetalleRequisicion",
                column: "requisicionid_detalle");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRequisicion_usuarioid_usuario",
                table: "DetalleRequisicion",
                column: "usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_criterioid_criterio",
                table: "Evaluacion",
                column: "criterioid_criterio");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_empresanit",
                table: "Evaluacion",
                column: "empresanit");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_id_categoria1",
                table: "Producto",
                column: "id_categoria1");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_id_tipo_producto1",
                table: "Producto",
                column: "id_tipo_producto1");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_id_rol1",
                table: "Usuario",
                column: "id_rol1");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactoid_contacto",
                table: "AgendaTelefonica",
                column: "contactoid_contacto",
                principalTable: "Contacto",
                principalColumn: "id_contacto");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Empresa_empresanit",
                table: "AgendaTelefonica",
                column: "empresanit",
                principalTable: "Empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_id_perfil1",
                table: "Empresa",
                column: "id_perfil1",
                principalTable: "Perfil",
                principalColumn: "id_perfil",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_TipoEmpresa_id_tipo_empresa1",
                table: "Empresa",
                column: "id_tipo_empresa1",
                principalTable: "TipoEmpresa",
                principalColumn: "id_tipo_empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactoid_contacto",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Empresa_empresanit",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_id_perfil1",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_id_tipo_empresa1",
                table: "Empresa");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "Evaluacion");

            migrationBuilder.DropTable(
                name: "CondicionEconomica");

            migrationBuilder.DropTable(
                name: "DetalleRequisicion");

            migrationBuilder.DropTable(
                name: "Criterio");

            migrationBuilder.DropTable(
                name: "DescuentoComercial");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "PlazoPago");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Requisicion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "TipoProducto");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.DropIndex(
                name: "IX_AgendaTelefonica_contactoid_contacto",
                table: "AgendaTelefonica");

            migrationBuilder.DropIndex(
                name: "IX_AgendaTelefonica_empresanit",
                table: "AgendaTelefonica");

            migrationBuilder.DropColumn(
                name: "id_contacto",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "contactoid_contacto",
                table: "AgendaTelefonica");

            migrationBuilder.DropColumn(
                name: "empresanit",
                table: "AgendaTelefonica");

            migrationBuilder.RenameColumn(
                name: "id_tipo_empresa",
                table: "TipoEmpresa",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "razon_social",
                table: "Perfil",
                newName: "razonSocial");

            migrationBuilder.RenameColumn(
                name: "id_perfil",
                table: "Perfil",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "nombre_representante",
                table: "Empresa",
                newName: "representante");

            migrationBuilder.RenameColumn(
                name: "id_tipo_empresa1",
                table: "Empresa",
                newName: "tipoEmpresaid");

            migrationBuilder.RenameColumn(
                name: "id_perfil1",
                table: "Empresa",
                newName: "perfilid");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_id_tipo_empresa1",
                table: "Empresa",
                newName: "IX_Empresa_tipoEmpresaid");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_id_perfil1",
                table: "Empresa",
                newName: "IX_Empresa_perfilid");

            migrationBuilder.RenameColumn(
                name: "nit",
                table: "AgendaTelefonica",
                newName: "idEmpresa");

            migrationBuilder.RenameColumn(
                name: "id_contacto",
                table: "AgendaTelefonica",
                newName: "idContacto");

            migrationBuilder.RenameColumn(
                name: "id_agenda",
                table: "AgendaTelefonica",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nit",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar=17",
                oldMaxLength: 17);

            migrationBuilder.AddColumn<string>(
                name: "id",
                table: "Contacto",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contactosid",
                table: "AgendaTelefonica",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "empresasnit",
                table: "AgendaTelefonica",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_contactosid",
                table: "AgendaTelefonica",
                column: "contactosid");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_empresasnit",
                table: "AgendaTelefonica",
                column: "empresasnit");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosid",
                table: "AgendaTelefonica",
                column: "contactosid",
                principalTable: "Contacto",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Empresa_empresasnit",
                table: "AgendaTelefonica",
                column: "empresasnit",
                principalTable: "Empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_perfilid",
                table: "Empresa",
                column: "perfilid",
                principalTable: "Perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaid",
                table: "Empresa",
                column: "tipoEmpresaid",
                principalTable: "TipoEmpresa",
                principalColumn: "id");
        }
    }
}
