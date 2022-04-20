using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class MigracionFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactoid_contacto",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Empresa_empresanit",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_CondicionEconomica_DescuentoComercial_id_descuento1",
                table: "CondicionEconomica");

            migrationBuilder.DropForeignKey(
                name: "FK_CondicionEconomica_FormaPago_id_pago1",
                table: "CondicionEconomica");

            migrationBuilder.DropForeignKey(
                name: "FK_CondicionEconomica_PlazoPago_id_plazoid_pago",
                table: "CondicionEconomica");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizacion_CondicionEconomica_id_condicion1",
                table: "Cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizacion_DetalleRequisicion_id_detalle1",
                table: "Cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Cotizacion_Empresa_empresanit",
                table: "Cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleRequisicion_Producto_productoid_producto",
                table: "DetalleRequisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleRequisicion_Requisicion_requisicionid_detalle",
                table: "DetalleRequisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleRequisicion_Usuario_usuarioid_usuario",
                table: "DetalleRequisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_id_perfil1",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_id_tipo_empresa1",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluacion_Criterio_criterioid_criterio",
                table: "Evaluacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluacion_Empresa_empresanit",
                table: "Evaluacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_id_categoria1",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_TipoProducto_id_tipo_producto1",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_id_rol1",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol",
                table: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requisicion",
                table: "Requisicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evaluacion",
                table: "Evaluacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Criterio",
                table: "Criterio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cotizacion",
                table: "Cotizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoProducto",
                table: "TipoProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEmpresa",
                table: "TipoEmpresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlazoPago",
                table: "PlazoPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaPago",
                table: "FormaPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleRequisicion",
                table: "DetalleRequisicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DescuentoComercial",
                table: "DescuentoComercial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CondicionEconomica",
                table: "CondicionEconomica");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "rol");

            migrationBuilder.RenameTable(
                name: "Requisicion",
                newName: "requisicion");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "producto");

            migrationBuilder.RenameTable(
                name: "Perfil",
                newName: "perfil");

            migrationBuilder.RenameTable(
                name: "Evaluacion",
                newName: "evaluacion");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "empresa");

            migrationBuilder.RenameTable(
                name: "Criterio",
                newName: "criterio");

            migrationBuilder.RenameTable(
                name: "Cotizacion",
                newName: "cotizacion");

            migrationBuilder.RenameTable(
                name: "Contacto",
                newName: "contacto");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "categoria");

            migrationBuilder.RenameTable(
                name: "TipoProducto",
                newName: "tipo_producto");

            migrationBuilder.RenameTable(
                name: "TipoEmpresa",
                newName: "tipo_empresa");

            migrationBuilder.RenameTable(
                name: "PlazoPago",
                newName: "plazo_pago");

            migrationBuilder.RenameTable(
                name: "FormaPago",
                newName: "forma_pago");

            migrationBuilder.RenameTable(
                name: "DetalleRequisicion",
                newName: "detalle_requisicion");

            migrationBuilder.RenameTable(
                name: "DescuentoComercial",
                newName: "desceunto_comercial");

            migrationBuilder.RenameTable(
                name: "CondicionEconomica",
                newName: "condicion_economica");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_id_rol1",
                table: "usuario",
                newName: "IX_usuario_id_rol1");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_id_tipo_producto1",
                table: "producto",
                newName: "IX_producto_id_tipo_producto1");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_id_categoria1",
                table: "producto",
                newName: "IX_producto_id_categoria1");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluacion_empresanit",
                table: "evaluacion",
                newName: "IX_evaluacion_empresanit");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluacion_criterioid_criterio",
                table: "evaluacion",
                newName: "IX_evaluacion_criterioid_criterio");

            migrationBuilder.RenameColumn(
                name: "Nrc",
                table: "empresa",
                newName: "nrc");

            migrationBuilder.RenameColumn(
                name: "Fax",
                table: "empresa",
                newName: "fax");

            migrationBuilder.RenameColumn(
                name: "telefonoMovil",
                table: "empresa",
                newName: "telefono_movil");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_id_tipo_empresa1",
                table: "empresa",
                newName: "IX_empresa_id_tipo_empresa1");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_id_perfil1",
                table: "empresa",
                newName: "IX_empresa_id_perfil1");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizacion_id_detalle1",
                table: "cotizacion",
                newName: "IX_cotizacion_id_detalle1");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizacion_id_condicion1",
                table: "cotizacion",
                newName: "IX_cotizacion_id_condicion1");

            migrationBuilder.RenameIndex(
                name: "IX_Cotizacion_empresanit",
                table: "cotizacion",
                newName: "IX_cotizacion_empresanit");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleRequisicion_usuarioid_usuario",
                table: "detalle_requisicion",
                newName: "IX_detalle_requisicion_usuarioid_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleRequisicion_requisicionid_detalle",
                table: "detalle_requisicion",
                newName: "IX_detalle_requisicion_requisicionid_detalle");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleRequisicion_productoid_producto",
                table: "detalle_requisicion",
                newName: "IX_detalle_requisicion_productoid_producto");

            migrationBuilder.RenameIndex(
                name: "IX_CondicionEconomica_id_plazoid_pago",
                table: "condicion_economica",
                newName: "IX_condicion_economica_id_plazoid_pago");

            migrationBuilder.RenameIndex(
                name: "IX_CondicionEconomica_id_pago1",
                table: "condicion_economica",
                newName: "IX_condicion_economica_id_pago1");

            migrationBuilder.RenameIndex(
                name: "IX_CondicionEconomica_id_descuento1",
                table: "condicion_economica",
                newName: "IX_condicion_economica_id_descuento1");

            migrationBuilder.AddColumn<int>(
                name: "id_referencia1",
                table: "perfil",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rubro",
                table: "empresa",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "varchar=100");

            migrationBuilder.AlterColumn<int>(
                name: "id_perfil1",
                table: "empresa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "logo",
                table: "empresa",
                type: "varchar=150",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ubicacion_geografica",
                table: "empresa",
                type: "varchar=150",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "id_usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rol",
                table: "rol",
                column: "id_rol");

            migrationBuilder.AddPrimaryKey(
                name: "PK_requisicion",
                table: "requisicion",
                column: "id_detalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto",
                table: "producto",
                column: "id_producto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfil",
                table: "perfil",
                column: "id_perfil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_evaluacion",
                table: "evaluacion",
                column: "id_evaluacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresa",
                table: "empresa",
                column: "nit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_criterio",
                table: "criterio",
                column: "id_criterio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion",
                column: "nit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacto",
                table: "contacto",
                column: "id_contacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoria",
                table: "categoria",
                column: "id_categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipo_producto",
                table: "tipo_producto",
                column: "id_tipo_producto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipo_empresa",
                table: "tipo_empresa",
                column: "id_tipo_empresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_plazo_pago",
                table: "plazo_pago",
                column: "id_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_forma_pago",
                table: "forma_pago",
                column: "id_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_detalle_requisicion",
                table: "detalle_requisicion",
                column: "id_detalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_desceunto_comercial",
                table: "desceunto_comercial",
                column: "id_descuento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_condicion_economica",
                table: "condicion_economica",
                column: "id_condicion");

            migrationBuilder.CreateTable(
                name: "contrato",
                columns: table => new
                {
                    id_contrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empresanit = table.Column<string>(type: "varchar=17", nullable: true),
                    id_usuario1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contrato", x => x.id_contrato);
                    table.ForeignKey(
                        name: "FK_contrato_empresa_empresanit",
                        column: x => x.empresanit,
                        principalTable: "empresa",
                        principalColumn: "nit");
                    table.ForeignKey(
                        name: "FK_contrato_usuario_id_usuario1",
                        column: x => x.id_usuario1,
                        principalTable: "usuario",
                        principalColumn: "id_usuario");
                });

            migrationBuilder.CreateTable(
                name: "direccion_general",
                columns: table => new
                {
                    id_direccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_perfil = table.Column<int>(type: "int", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    perfilid_perfil = table.Column<int>(type: "int", nullable: true),
                    usuarioid_usuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direccion_general", x => x.id_direccion);
                    table.ForeignKey(
                        name: "FK_direccion_general_perfil_perfilid_perfil",
                        column: x => x.perfilid_perfil,
                        principalTable: "perfil",
                        principalColumn: "id_perfil");
                    table.ForeignKey(
                        name: "FK_direccion_general_usuario_usuarioid_usuario",
                        column: x => x.usuarioid_usuario,
                        principalTable: "usuario",
                        principalColumn: "id_usuario");
                });

            migrationBuilder.CreateTable(
                name: "establecimiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_establecimiento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    id_inventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    existencia = table.Column<int>(type: "int", nullable: false),
                    entrada = table.Column<int>(type: "int", nullable: false),
                    salida = table.Column<int>(type: "int", nullable: false),
                    productoid_producto = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario", x => x.id_inventario);
                    table.ForeignKey(
                        name: "FK_inventario_producto_productoid_producto",
                        column: x => x.productoid_producto,
                        principalTable: "producto",
                        principalColumn: "id_producto");
                });

            migrationBuilder.CreateTable(
                name: "permiso",
                columns: table => new
                {
                    id_permiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar=100", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permiso", x => x.id_permiso);
                });

            migrationBuilder.CreateTable(
                name: "referencia",
                columns: table => new
                {
                    id_referencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor_negocio = table.Column<double>(type: "float", nullable: false),
                    id_agenda1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referencia", x => x.id_referencia);
                    table.ForeignKey(
                        name: "FK_referencia_AgendaTelefonica_id_agenda1",
                        column: x => x.id_agenda1,
                        principalTable: "AgendaTelefonica",
                        principalColumn: "id_agenda");
                });

            migrationBuilder.CreateTable(
                name: "img_establecimiento",
                columns: table => new
                {
                    id_imagen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_establecimiento = table.Column<int>(type: "int", nullable: true),
                    imagen_establecimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresanit = table.Column<string>(type: "varchar=17", nullable: true),
                    establecimientoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_img_establecimiento", x => x.id_imagen);
                    table.ForeignKey(
                        name: "FK_img_establecimiento_empresa_empresanit",
                        column: x => x.empresanit,
                        principalTable: "empresa",
                        principalColumn: "nit");
                    table.ForeignKey(
                        name: "FK_img_establecimiento_establecimiento_establecimientoid",
                        column: x => x.establecimientoid,
                        principalTable: "establecimiento",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "privilegio",
                columns: table => new
                {
                    id_privilegio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_permiso1 = table.Column<int>(type: "int", nullable: true),
                    id_usuario1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privilegio", x => x.id_privilegio);
                    table.ForeignKey(
                        name: "FK_privilegio_permiso_id_permiso1",
                        column: x => x.id_permiso1,
                        principalTable: "permiso",
                        principalColumn: "id_permiso");
                    table.ForeignKey(
                        name: "FK_privilegio_usuario_id_usuario1",
                        column: x => x.id_usuario1,
                        principalTable: "usuario",
                        principalColumn: "id_usuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_perfil_id_referencia1",
                table: "perfil",
                column: "id_referencia1");

            migrationBuilder.CreateIndex(
                name: "IX_contrato_empresanit",
                table: "contrato",
                column: "empresanit");

            migrationBuilder.CreateIndex(
                name: "IX_contrato_id_usuario1",
                table: "contrato",
                column: "id_usuario1");

            migrationBuilder.CreateIndex(
                name: "IX_direccion_general_perfilid_perfil",
                table: "direccion_general",
                column: "perfilid_perfil");

            migrationBuilder.CreateIndex(
                name: "IX_direccion_general_usuarioid_usuario",
                table: "direccion_general",
                column: "usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_img_establecimiento_empresanit",
                table: "img_establecimiento",
                column: "empresanit");

            migrationBuilder.CreateIndex(
                name: "IX_img_establecimiento_establecimientoid",
                table: "img_establecimiento",
                column: "establecimientoid");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_productoid_producto",
                table: "inventario",
                column: "productoid_producto");

            migrationBuilder.CreateIndex(
                name: "IX_privilegio_id_permiso1",
                table: "privilegio",
                column: "id_permiso1");

            migrationBuilder.CreateIndex(
                name: "IX_privilegio_id_usuario1",
                table: "privilegio",
                column: "id_usuario1");

            migrationBuilder.CreateIndex(
                name: "IX_referencia_id_agenda1",
                table: "referencia",
                column: "id_agenda1");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_contacto_contactoid_contacto",
                table: "AgendaTelefonica",
                column: "contactoid_contacto",
                principalTable: "contacto",
                principalColumn: "id_contacto");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_empresa_empresanit",
                table: "AgendaTelefonica",
                column: "empresanit",
                principalTable: "empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_condicion_economica_desceunto_comercial_id_descuento1",
                table: "condicion_economica",
                column: "id_descuento1",
                principalTable: "desceunto_comercial",
                principalColumn: "id_descuento");

            migrationBuilder.AddForeignKey(
                name: "FK_condicion_economica_forma_pago_id_pago1",
                table: "condicion_economica",
                column: "id_pago1",
                principalTable: "forma_pago",
                principalColumn: "id_pago");

            migrationBuilder.AddForeignKey(
                name: "FK_condicion_economica_plazo_pago_id_plazoid_pago",
                table: "condicion_economica",
                column: "id_plazoid_pago",
                principalTable: "plazo_pago",
                principalColumn: "id_pago");

            migrationBuilder.AddForeignKey(
                name: "FK_cotizacion_condicion_economica_id_condicion1",
                table: "cotizacion",
                column: "id_condicion1",
                principalTable: "condicion_economica",
                principalColumn: "id_condicion");

            migrationBuilder.AddForeignKey(
                name: "FK_cotizacion_detalle_requisicion_id_detalle1",
                table: "cotizacion",
                column: "id_detalle1",
                principalTable: "detalle_requisicion",
                principalColumn: "id_detalle");

            migrationBuilder.AddForeignKey(
                name: "FK_cotizacion_empresa_empresanit",
                table: "cotizacion",
                column: "empresanit",
                principalTable: "empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_requisicion_producto_productoid_producto",
                table: "detalle_requisicion",
                column: "productoid_producto",
                principalTable: "producto",
                principalColumn: "id_producto");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_requisicion_requisicion_requisicionid_detalle",
                table: "detalle_requisicion",
                column: "requisicionid_detalle",
                principalTable: "requisicion",
                principalColumn: "id_detalle");

            migrationBuilder.AddForeignKey(
                name: "FK_detalle_requisicion_usuario_usuarioid_usuario",
                table: "detalle_requisicion",
                column: "usuarioid_usuario",
                principalTable: "usuario",
                principalColumn: "id_usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_perfil_id_perfil1",
                table: "empresa",
                column: "id_perfil1",
                principalTable: "perfil",
                principalColumn: "id_perfil");

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_tipo_empresa_id_tipo_empresa1",
                table: "empresa",
                column: "id_tipo_empresa1",
                principalTable: "tipo_empresa",
                principalColumn: "id_tipo_empresa");

            migrationBuilder.AddForeignKey(
                name: "FK_evaluacion_criterio_criterioid_criterio",
                table: "evaluacion",
                column: "criterioid_criterio",
                principalTable: "criterio",
                principalColumn: "id_criterio");

            migrationBuilder.AddForeignKey(
                name: "FK_evaluacion_empresa_empresanit",
                table: "evaluacion",
                column: "empresanit",
                principalTable: "empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_perfil_referencia_id_referencia1",
                table: "perfil",
                column: "id_referencia1",
                principalTable: "referencia",
                principalColumn: "id_referencia");

            migrationBuilder.AddForeignKey(
                name: "FK_producto_categoria_id_categoria1",
                table: "producto",
                column: "id_categoria1",
                principalTable: "categoria",
                principalColumn: "id_categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_producto_tipo_producto_id_tipo_producto1",
                table: "producto",
                column: "id_tipo_producto1",
                principalTable: "tipo_producto",
                principalColumn: "id_tipo_producto");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_rol_id_rol1",
                table: "usuario",
                column: "id_rol1",
                principalTable: "rol",
                principalColumn: "id_rol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_contacto_contactoid_contacto",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_empresa_empresanit",
                table: "AgendaTelefonica");

            migrationBuilder.DropForeignKey(
                name: "FK_condicion_economica_desceunto_comercial_id_descuento1",
                table: "condicion_economica");

            migrationBuilder.DropForeignKey(
                name: "FK_condicion_economica_forma_pago_id_pago1",
                table: "condicion_economica");

            migrationBuilder.DropForeignKey(
                name: "FK_condicion_economica_plazo_pago_id_plazoid_pago",
                table: "condicion_economica");

            migrationBuilder.DropForeignKey(
                name: "FK_cotizacion_condicion_economica_id_condicion1",
                table: "cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_cotizacion_detalle_requisicion_id_detalle1",
                table: "cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_cotizacion_empresa_empresanit",
                table: "cotizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_detalle_requisicion_producto_productoid_producto",
                table: "detalle_requisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_detalle_requisicion_requisicion_requisicionid_detalle",
                table: "detalle_requisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_detalle_requisicion_usuario_usuarioid_usuario",
                table: "detalle_requisicion");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_perfil_id_perfil1",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_tipo_empresa_id_tipo_empresa1",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_evaluacion_criterio_criterioid_criterio",
                table: "evaluacion");

            migrationBuilder.DropForeignKey(
                name: "FK_evaluacion_empresa_empresanit",
                table: "evaluacion");

            migrationBuilder.DropForeignKey(
                name: "FK_perfil_referencia_id_referencia1",
                table: "perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_producto_categoria_id_categoria1",
                table: "producto");

            migrationBuilder.DropForeignKey(
                name: "FK_producto_tipo_producto_id_tipo_producto1",
                table: "producto");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_rol_id_rol1",
                table: "usuario");

            migrationBuilder.DropTable(
                name: "contrato");

            migrationBuilder.DropTable(
                name: "direccion_general");

            migrationBuilder.DropTable(
                name: "img_establecimiento");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "privilegio");

            migrationBuilder.DropTable(
                name: "referencia");

            migrationBuilder.DropTable(
                name: "establecimiento");

            migrationBuilder.DropTable(
                name: "permiso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rol",
                table: "rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_requisicion",
                table: "requisicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto",
                table: "producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfil",
                table: "perfil");

            migrationBuilder.DropIndex(
                name: "IX_perfil_id_referencia1",
                table: "perfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_evaluacion",
                table: "evaluacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresa",
                table: "empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_criterio",
                table: "criterio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacto",
                table: "contacto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoria",
                table: "categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipo_producto",
                table: "tipo_producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipo_empresa",
                table: "tipo_empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_plazo_pago",
                table: "plazo_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_forma_pago",
                table: "forma_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_detalle_requisicion",
                table: "detalle_requisicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_desceunto_comercial",
                table: "desceunto_comercial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_condicion_economica",
                table: "condicion_economica");

            migrationBuilder.DropColumn(
                name: "id_referencia1",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "logo",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "ubicacion_geografica",
                table: "empresa");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "rol",
                newName: "Rol");

            migrationBuilder.RenameTable(
                name: "requisicion",
                newName: "Requisicion");

            migrationBuilder.RenameTable(
                name: "producto",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "perfil",
                newName: "Perfil");

            migrationBuilder.RenameTable(
                name: "evaluacion",
                newName: "Evaluacion");

            migrationBuilder.RenameTable(
                name: "empresa",
                newName: "Empresa");

            migrationBuilder.RenameTable(
                name: "criterio",
                newName: "Criterio");

            migrationBuilder.RenameTable(
                name: "cotizacion",
                newName: "Cotizacion");

            migrationBuilder.RenameTable(
                name: "contacto",
                newName: "Contacto");

            migrationBuilder.RenameTable(
                name: "categoria",
                newName: "Categoria");

            migrationBuilder.RenameTable(
                name: "tipo_producto",
                newName: "TipoProducto");

            migrationBuilder.RenameTable(
                name: "tipo_empresa",
                newName: "TipoEmpresa");

            migrationBuilder.RenameTable(
                name: "plazo_pago",
                newName: "PlazoPago");

            migrationBuilder.RenameTable(
                name: "forma_pago",
                newName: "FormaPago");

            migrationBuilder.RenameTable(
                name: "detalle_requisicion",
                newName: "DetalleRequisicion");

            migrationBuilder.RenameTable(
                name: "desceunto_comercial",
                newName: "DescuentoComercial");

            migrationBuilder.RenameTable(
                name: "condicion_economica",
                newName: "CondicionEconomica");

            migrationBuilder.RenameIndex(
                name: "IX_usuario_id_rol1",
                table: "Usuario",
                newName: "IX_Usuario_id_rol1");

            migrationBuilder.RenameIndex(
                name: "IX_producto_id_tipo_producto1",
                table: "Producto",
                newName: "IX_Producto_id_tipo_producto1");

            migrationBuilder.RenameIndex(
                name: "IX_producto_id_categoria1",
                table: "Producto",
                newName: "IX_Producto_id_categoria1");

            migrationBuilder.RenameIndex(
                name: "IX_evaluacion_empresanit",
                table: "Evaluacion",
                newName: "IX_Evaluacion_empresanit");

            migrationBuilder.RenameIndex(
                name: "IX_evaluacion_criterioid_criterio",
                table: "Evaluacion",
                newName: "IX_Evaluacion_criterioid_criterio");

            migrationBuilder.RenameColumn(
                name: "nrc",
                table: "Empresa",
                newName: "Nrc");

            migrationBuilder.RenameColumn(
                name: "fax",
                table: "Empresa",
                newName: "Fax");

            migrationBuilder.RenameColumn(
                name: "telefono_movil",
                table: "Empresa",
                newName: "telefonoMovil");

            migrationBuilder.RenameIndex(
                name: "IX_empresa_id_tipo_empresa1",
                table: "Empresa",
                newName: "IX_Empresa_id_tipo_empresa1");

            migrationBuilder.RenameIndex(
                name: "IX_empresa_id_perfil1",
                table: "Empresa",
                newName: "IX_Empresa_id_perfil1");

            migrationBuilder.RenameIndex(
                name: "IX_cotizacion_id_detalle1",
                table: "Cotizacion",
                newName: "IX_Cotizacion_id_detalle1");

            migrationBuilder.RenameIndex(
                name: "IX_cotizacion_id_condicion1",
                table: "Cotizacion",
                newName: "IX_Cotizacion_id_condicion1");

            migrationBuilder.RenameIndex(
                name: "IX_cotizacion_empresanit",
                table: "Cotizacion",
                newName: "IX_Cotizacion_empresanit");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_requisicion_usuarioid_usuario",
                table: "DetalleRequisicion",
                newName: "IX_DetalleRequisicion_usuarioid_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_requisicion_requisicionid_detalle",
                table: "DetalleRequisicion",
                newName: "IX_DetalleRequisicion_requisicionid_detalle");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_requisicion_productoid_producto",
                table: "DetalleRequisicion",
                newName: "IX_DetalleRequisicion_productoid_producto");

            migrationBuilder.RenameIndex(
                name: "IX_condicion_economica_id_plazoid_pago",
                table: "CondicionEconomica",
                newName: "IX_CondicionEconomica_id_plazoid_pago");

            migrationBuilder.RenameIndex(
                name: "IX_condicion_economica_id_pago1",
                table: "CondicionEconomica",
                newName: "IX_CondicionEconomica_id_pago1");

            migrationBuilder.RenameIndex(
                name: "IX_condicion_economica_id_descuento1",
                table: "CondicionEconomica",
                newName: "IX_CondicionEconomica_id_descuento1");

            migrationBuilder.AlterColumn<int>(
                name: "rubro",
                table: "Empresa",
                type: "varchar=100",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_perfil1",
                table: "Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "id_usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Rol",
                column: "id_rol");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requisicion",
                table: "Requisicion",
                column: "id_detalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "id_producto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "id_perfil");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evaluacion",
                table: "Evaluacion",
                column: "id_evaluacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "nit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Criterio",
                table: "Criterio",
                column: "id_criterio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cotizacion",
                table: "Cotizacion",
                column: "nit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "id_contacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "id_categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoProducto",
                table: "TipoProducto",
                column: "id_tipo_producto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEmpresa",
                table: "TipoEmpresa",
                column: "id_tipo_empresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlazoPago",
                table: "PlazoPago",
                column: "id_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaPago",
                table: "FormaPago",
                column: "id_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleRequisicion",
                table: "DetalleRequisicion",
                column: "id_detalle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DescuentoComercial",
                table: "DescuentoComercial",
                column: "id_descuento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CondicionEconomica",
                table: "CondicionEconomica",
                column: "id_condicion");

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
                name: "FK_CondicionEconomica_DescuentoComercial_id_descuento1",
                table: "CondicionEconomica",
                column: "id_descuento1",
                principalTable: "DescuentoComercial",
                principalColumn: "id_descuento");

            migrationBuilder.AddForeignKey(
                name: "FK_CondicionEconomica_FormaPago_id_pago1",
                table: "CondicionEconomica",
                column: "id_pago1",
                principalTable: "FormaPago",
                principalColumn: "id_pago");

            migrationBuilder.AddForeignKey(
                name: "FK_CondicionEconomica_PlazoPago_id_plazoid_pago",
                table: "CondicionEconomica",
                column: "id_plazoid_pago",
                principalTable: "PlazoPago",
                principalColumn: "id_pago");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizacion_CondicionEconomica_id_condicion1",
                table: "Cotizacion",
                column: "id_condicion1",
                principalTable: "CondicionEconomica",
                principalColumn: "id_condicion");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizacion_DetalleRequisicion_id_detalle1",
                table: "Cotizacion",
                column: "id_detalle1",
                principalTable: "DetalleRequisicion",
                principalColumn: "id_detalle");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizacion_Empresa_empresanit",
                table: "Cotizacion",
                column: "empresanit",
                principalTable: "Empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleRequisicion_Producto_productoid_producto",
                table: "DetalleRequisicion",
                column: "productoid_producto",
                principalTable: "Producto",
                principalColumn: "id_producto");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleRequisicion_Requisicion_requisicionid_detalle",
                table: "DetalleRequisicion",
                column: "requisicionid_detalle",
                principalTable: "Requisicion",
                principalColumn: "id_detalle");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleRequisicion_Usuario_usuarioid_usuario",
                table: "DetalleRequisicion",
                column: "usuarioid_usuario",
                principalTable: "Usuario",
                principalColumn: "id_usuario");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluacion_Criterio_criterioid_criterio",
                table: "Evaluacion",
                column: "criterioid_criterio",
                principalTable: "Criterio",
                principalColumn: "id_criterio");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluacion_Empresa_empresanit",
                table: "Evaluacion",
                column: "empresanit",
                principalTable: "Empresa",
                principalColumn: "nit");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_id_categoria1",
                table: "Producto",
                column: "id_categoria1",
                principalTable: "Categoria",
                principalColumn: "id_categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_TipoProducto_id_tipo_producto1",
                table: "Producto",
                column: "id_tipo_producto1",
                principalTable: "TipoProducto",
                principalColumn: "id_tipo_producto");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_id_rol1",
                table: "Usuario",
                column: "id_rol1",
                principalTable: "Rol",
                principalColumn: "id_rol");
        }
    }
}
