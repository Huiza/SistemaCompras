// <auto-generated />
using System;
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220420045855_MigracionFinal")]
    partial class MigracionFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Models.AgendaTelefonica", b =>
                {
                    b.Property<int>("id_agenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_agenda"), 1L, 1);

                    b.Property<int?>("contactoid_contacto")
                        .HasColumnType("int");

                    b.Property<string>("empresanit")
                        .HasColumnType("varchar=17");

                    b.Property<int>("id_contacto")
                        .HasColumnType("int");

                    b.Property<int>("nit")
                        .HasColumnType("int");

                    b.HasKey("id_agenda");

                    b.HasIndex("contactoid_contacto");

                    b.HasIndex("empresanit");

                    b.ToTable("AgendaTelefonica");
                });

            modelBuilder.Entity("Backend.Models.Categoria", b =>
                {
                    b.Property<int>("id_categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_categoria"), 1L, 1);

                    b.Property<string>("nombre")
                        .HasMaxLength(25)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_categoria");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("Backend.Models.CondicionEconomica", b =>
                {
                    b.Property<int>("id_condicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_condicion"), 1L, 1);

                    b.Property<int?>("id_descuento1")
                        .HasColumnType("int");

                    b.Property<int?>("id_pago1")
                        .HasColumnType("int");

                    b.Property<int?>("id_plazoid_pago")
                        .HasColumnType("int");

                    b.Property<double?>("pago_transporte")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double?>("precio_embalajes")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double?>("precio_envases")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double?>("recargo_aplazamiento")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("id_condicion");

                    b.HasIndex("id_descuento1");

                    b.HasIndex("id_pago1");

                    b.HasIndex("id_plazoid_pago");

                    b.ToTable("condicion_economica");
                });

            modelBuilder.Entity("Backend.Models.Contacto", b =>
                {
                    b.Property<int?>("id_contacto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id_contacto"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar=100");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.HasKey("id_contacto");

                    b.ToTable("contacto");
                });

            modelBuilder.Entity("Backend.Models.Contrato", b =>
                {
                    b.Property<int>("id_contrato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_contrato"), 1L, 1);

                    b.Property<string>("empresanit")
                        .HasColumnType("varchar=17");

                    b.Property<int?>("id_usuario1")
                        .HasColumnType("int");

                    b.HasKey("id_contrato");

                    b.HasIndex("empresanit");

                    b.HasIndex("id_usuario1");

                    b.ToTable("contrato");
                });

            modelBuilder.Entity("Backend.Models.Cotizacion", b =>
                {
                    b.Property<string>("nit")
                        .HasMaxLength(17)
                        .HasColumnType("varchar=17");

                    b.Property<string>("empresanit")
                        .HasColumnType("varchar=17");

                    b.Property<DateTime?>("fecha")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("id_condicion1")
                        .HasColumnType("int");

                    b.Property<int?>("id_detalle1")
                        .HasColumnType("int");

                    b.HasKey("nit");

                    b.HasIndex("empresanit");

                    b.HasIndex("id_condicion1");

                    b.HasIndex("id_detalle1");

                    b.ToTable("cotizacion");
                });

            modelBuilder.Entity("Backend.Models.Criterio", b =>
                {
                    b.Property<int?>("id_criterio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id_criterio"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_criterio");

                    b.ToTable("criterio");
                });

            modelBuilder.Entity("Backend.Models.DescuentoComercial", b =>
                {
                    b.Property<int>("id_descuento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_descuento"), 1L, 1);

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_descuento");

                    b.ToTable("desceunto_comercial");
                });

            modelBuilder.Entity("Backend.Models.DetalleRequisicion", b =>
                {
                    b.Property<int>("id_detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_detalle"), 1L, 1);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("id_producto")
                        .HasColumnType("int");

                    b.Property<int>("id_requisicion")
                        .HasColumnType("int");

                    b.Property<string>("productoid_producto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("requisicionid_detalle")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioid_usuario")
                        .HasColumnType("int");

                    b.HasKey("id_detalle");

                    b.HasIndex("productoid_producto");

                    b.HasIndex("requisicionid_detalle");

                    b.HasIndex("usuarioid_usuario");

                    b.ToTable("detalle_requisicion");
                });

            modelBuilder.Entity("Backend.Models.DireccionGeneral", b =>
                {
                    b.Property<int>("id_direccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_direccion"), 1L, 1);

                    b.Property<int>("id_perfil")
                        .HasColumnType("int");

                    b.Property<int>("id_usuario")
                        .HasColumnType("int");

                    b.Property<int?>("perfilid_perfil")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioid_usuario")
                        .HasColumnType("int");

                    b.HasKey("id_direccion");

                    b.HasIndex("perfilid_perfil");

                    b.HasIndex("usuarioid_usuario");

                    b.ToTable("direccion_general");
                });

            modelBuilder.Entity("Backend.Models.Empresa", b =>
                {
                    b.Property<string>("nit")
                        .HasMaxLength(17)
                        .HasColumnType("varchar=17");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=150");

                    b.Property<string>("fax")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<int?>("id_perfil1")
                        .HasColumnType("int");

                    b.Property<int?>("id_tipo_empresa1")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .IsRequired()
                        .HasColumnType("varchar=150");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("nombre_representante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("nrc")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("varchar=17");

                    b.Property<int?>("rubro")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<string>("telefono_movil")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar=9");

                    b.Property<string>("ubicacion_geografica")
                        .IsRequired()
                        .HasColumnType("varchar=150");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("nit");

                    b.HasIndex("id_perfil1");

                    b.HasIndex("id_tipo_empresa1");

                    b.ToTable("empresa");
                });

            modelBuilder.Entity("Backend.Models.Establecimiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("establecimiento");
                });

            modelBuilder.Entity("Backend.Models.Evaluacion", b =>
                {
                    b.Property<int>("id_evaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_evaluacion"), 1L, 1);

                    b.Property<int?>("criterioid_criterio")
                        .HasColumnType("int");

                    b.Property<string>("empresanit")
                        .HasColumnType("varchar=17");

                    b.Property<int>("id_criterio")
                        .HasColumnType("int");

                    b.Property<int>("nit")
                        .HasColumnType("int");

                    b.Property<int>("nota")
                        .HasColumnType("int");

                    b.HasKey("id_evaluacion");

                    b.HasIndex("criterioid_criterio");

                    b.HasIndex("empresanit");

                    b.ToTable("evaluacion");
                });

            modelBuilder.Entity("Backend.Models.FormaPago", b =>
                {
                    b.Property<int>("id_pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_pago"), 1L, 1);

                    b.Property<string>("tipo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_pago");

                    b.ToTable("forma_pago");
                });

            modelBuilder.Entity("Backend.Models.ImagenEstablecimiento", b =>
                {
                    b.Property<int>("id_imagen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_imagen"), 1L, 1);

                    b.Property<string>("empresanit")
                        .HasColumnType("varchar=17");

                    b.Property<int?>("establecimientoid")
                        .HasColumnType("int");

                    b.Property<int?>("id_establecimiento")
                        .HasColumnType("int");

                    b.Property<string>("imagen_establecimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_imagen");

                    b.HasIndex("empresanit");

                    b.HasIndex("establecimientoid");

                    b.ToTable("img_establecimiento");
                });

            modelBuilder.Entity("Backend.Models.Inventario", b =>
                {
                    b.Property<int>("id_inventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_inventario"), 1L, 1);

                    b.Property<int>("entrada")
                        .HasColumnType("int");

                    b.Property<int>("existencia")
                        .HasColumnType("int");

                    b.Property<string>("productoid_producto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("salida")
                        .HasColumnType("int");

                    b.HasKey("id_inventario");

                    b.HasIndex("productoid_producto");

                    b.ToTable("inventario");
                });

            modelBuilder.Entity("Backend.Models.Perfil", b =>
                {
                    b.Property<int>("id_perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_perfil"), 1L, 1);

                    b.Property<string>("calificacion")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=1");

                    b.Property<string>("escrituras")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<int?>("id_referencia1")
                        .HasColumnType("int");

                    b.Property<string>("razon_social")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<bool>("sucursal")
                        .HasColumnType("bit");

                    b.HasKey("id_perfil");

                    b.HasIndex("id_referencia1");

                    b.ToTable("perfil");
                });

            modelBuilder.Entity("Backend.Models.Permiso", b =>
                {
                    b.Property<int>("id_permiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_permiso"), 1L, 1);

                    b.Property<string>("nombre")
                        .HasMaxLength(25)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_permiso");

                    b.ToTable("permiso");
                });

            modelBuilder.Entity("Backend.Models.PlazoPago", b =>
                {
                    b.Property<int>("id_pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_pago"), 1L, 1);

                    b.Property<string>("periodo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_pago");

                    b.ToTable("plazo_pago");
                });

            modelBuilder.Entity("Backend.Models.Privilegio", b =>
                {
                    b.Property<int>("id_privilegio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_privilegio"), 1L, 1);

                    b.Property<int?>("id_permiso1")
                        .HasColumnType("int");

                    b.Property<int?>("id_usuario1")
                        .HasColumnType("int");

                    b.HasKey("id_privilegio");

                    b.HasIndex("id_permiso1");

                    b.HasIndex("id_usuario1");

                    b.ToTable("privilegio");
                });

            modelBuilder.Entity("Backend.Models.Producto", b =>
                {
                    b.Property<string>("id_producto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("caracteristica")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<string>("garantia")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<int?>("id_categoria1")
                        .HasColumnType("int");

                    b.Property<string>("id_tipo_producto1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("imagen")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar=100");

                    b.Property<string>("medida")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.Property<double?>("precio")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("utilidad")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar=150");

                    b.HasKey("id_producto");

                    b.HasIndex("id_categoria1");

                    b.HasIndex("id_tipo_producto1");

                    b.ToTable("producto");
                });

            modelBuilder.Entity("Backend.Models.Referencia", b =>
                {
                    b.Property<int>("id_referencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_referencia"), 1L, 1);

                    b.Property<int?>("id_agenda1")
                        .HasColumnType("int");

                    b.Property<double>("valor_negocio")
                        .HasColumnType("float");

                    b.HasKey("id_referencia");

                    b.HasIndex("id_agenda1");

                    b.ToTable("referencia");
                });

            modelBuilder.Entity("Backend.Models.Requisicion", b =>
                {
                    b.Property<int>("id_detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_detalle"), 1L, 1);

                    b.Property<DateTime?>("fecha")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecha_estimada")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("prioridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_detalle");

                    b.ToTable("requisicion");
                });

            modelBuilder.Entity("Backend.Models.Rol", b =>
                {
                    b.Property<int>("id_rol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_rol"), 1L, 1);

                    b.Property<string>("nombre")
                        .HasMaxLength(25)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_rol");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("Backend.Models.TipoEmpresa", b =>
                {
                    b.Property<int>("id_tipo_empresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_tipo_empresa"), 1L, 1);

                    b.Property<string>("tipo")
                        .HasMaxLength(150)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_tipo_empresa");

                    b.ToTable("tipo_empresa");
                });

            modelBuilder.Entity("Backend.Models.TipoProducto", b =>
                {
                    b.Property<string>("id_tipo_producto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nombre")
                        .HasMaxLength(150)
                        .HasColumnType("varchar=100");

                    b.HasKey("id_tipo_producto");

                    b.ToTable("tipo_producto");
                });

            modelBuilder.Entity("Backend.Models.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_usuario"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar=150");

                    b.Property<int?>("id_rol1")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar=100");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar=150");

                    b.HasKey("id_usuario");

                    b.HasIndex("id_rol1");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("Backend.Models.AgendaTelefonica", b =>
                {
                    b.HasOne("Backend.Models.Contacto", "contacto")
                        .WithMany("contactos")
                        .HasForeignKey("contactoid_contacto");

                    b.HasOne("Backend.Models.Empresa", "empresa")
                        .WithMany("contactos")
                        .HasForeignKey("empresanit");

                    b.Navigation("contacto");

                    b.Navigation("empresa");
                });

            modelBuilder.Entity("Backend.Models.CondicionEconomica", b =>
                {
                    b.HasOne("Backend.Models.DescuentoComercial", "id_descuento")
                        .WithMany()
                        .HasForeignKey("id_descuento1");

                    b.HasOne("Backend.Models.FormaPago", "id_pago")
                        .WithMany()
                        .HasForeignKey("id_pago1");

                    b.HasOne("Backend.Models.PlazoPago", "id_plazo")
                        .WithMany()
                        .HasForeignKey("id_plazoid_pago");

                    b.Navigation("id_descuento");

                    b.Navigation("id_pago");

                    b.Navigation("id_plazo");
                });

            modelBuilder.Entity("Backend.Models.Contrato", b =>
                {
                    b.HasOne("Backend.Models.Empresa", "empresa")
                        .WithMany("contratos")
                        .HasForeignKey("empresanit");

                    b.HasOne("Backend.Models.Usuario", "id_usuario")
                        .WithMany("contratos")
                        .HasForeignKey("id_usuario1");

                    b.Navigation("empresa");

                    b.Navigation("id_usuario");
                });

            modelBuilder.Entity("Backend.Models.Cotizacion", b =>
                {
                    b.HasOne("Backend.Models.Empresa", "empresa")
                        .WithMany("cotizaciones")
                        .HasForeignKey("empresanit");

                    b.HasOne("Backend.Models.CondicionEconomica", "id_condicion")
                        .WithMany()
                        .HasForeignKey("id_condicion1");

                    b.HasOne("Backend.Models.DetalleRequisicion", "id_detalle")
                        .WithMany("cotizaciones")
                        .HasForeignKey("id_detalle1");

                    b.Navigation("empresa");

                    b.Navigation("id_condicion");

                    b.Navigation("id_detalle");
                });

            modelBuilder.Entity("Backend.Models.DetalleRequisicion", b =>
                {
                    b.HasOne("Backend.Models.Producto", "producto")
                        .WithMany("detalles")
                        .HasForeignKey("productoid_producto");

                    b.HasOne("Backend.Models.Requisicion", "requisicion")
                        .WithMany("detalles")
                        .HasForeignKey("requisicionid_detalle");

                    b.HasOne("Backend.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid_usuario");

                    b.Navigation("producto");

                    b.Navigation("requisicion");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Backend.Models.DireccionGeneral", b =>
                {
                    b.HasOne("Backend.Models.Perfil", "perfil")
                        .WithMany("directores")
                        .HasForeignKey("perfilid_perfil");

                    b.HasOne("Backend.Models.Usuario", "usuario")
                        .WithMany("directores")
                        .HasForeignKey("usuarioid_usuario");

                    b.Navigation("perfil");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Backend.Models.Empresa", b =>
                {
                    b.HasOne("Backend.Models.Perfil", "id_perfil")
                        .WithMany()
                        .HasForeignKey("id_perfil1");

                    b.HasOne("Backend.Models.TipoEmpresa", "id_tipo_empresa")
                        .WithMany()
                        .HasForeignKey("id_tipo_empresa1");

                    b.Navigation("id_perfil");

                    b.Navigation("id_tipo_empresa");
                });

            modelBuilder.Entity("Backend.Models.Evaluacion", b =>
                {
                    b.HasOne("Backend.Models.Criterio", "criterio")
                        .WithMany("evaluaciones")
                        .HasForeignKey("criterioid_criterio");

                    b.HasOne("Backend.Models.Empresa", "empresa")
                        .WithMany("evaluaciones")
                        .HasForeignKey("empresanit");

                    b.Navigation("criterio");

                    b.Navigation("empresa");
                });

            modelBuilder.Entity("Backend.Models.ImagenEstablecimiento", b =>
                {
                    b.HasOne("Backend.Models.Empresa", "empresa")
                        .WithMany("img_establecimientos")
                        .HasForeignKey("empresanit");

                    b.HasOne("Backend.Models.Establecimiento", "establecimiento")
                        .WithMany("img_establecimientos")
                        .HasForeignKey("establecimientoid");

                    b.Navigation("empresa");

                    b.Navigation("establecimiento");
                });

            modelBuilder.Entity("Backend.Models.Inventario", b =>
                {
                    b.HasOne("Backend.Models.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoid_producto");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("Backend.Models.Perfil", b =>
                {
                    b.HasOne("Backend.Models.Referencia", "id_referencia")
                        .WithMany()
                        .HasForeignKey("id_referencia1");

                    b.Navigation("id_referencia");
                });

            modelBuilder.Entity("Backend.Models.Privilegio", b =>
                {
                    b.HasOne("Backend.Models.Permiso", "id_permiso")
                        .WithMany("privilegios")
                        .HasForeignKey("id_permiso1");

                    b.HasOne("Backend.Models.Usuario", "id_usuario")
                        .WithMany("privilegios")
                        .HasForeignKey("id_usuario1");

                    b.Navigation("id_permiso");

                    b.Navigation("id_usuario");
                });

            modelBuilder.Entity("Backend.Models.Producto", b =>
                {
                    b.HasOne("Backend.Models.Categoria", "id_categoria")
                        .WithMany()
                        .HasForeignKey("id_categoria1");

                    b.HasOne("Backend.Models.TipoProducto", "id_tipo_producto")
                        .WithMany()
                        .HasForeignKey("id_tipo_producto1");

                    b.Navigation("id_categoria");

                    b.Navigation("id_tipo_producto");
                });

            modelBuilder.Entity("Backend.Models.Referencia", b =>
                {
                    b.HasOne("Backend.Models.AgendaTelefonica", "id_agenda")
                        .WithMany()
                        .HasForeignKey("id_agenda1");

                    b.Navigation("id_agenda");
                });

            modelBuilder.Entity("Backend.Models.Usuario", b =>
                {
                    b.HasOne("Backend.Models.Rol", "id_rol")
                        .WithMany()
                        .HasForeignKey("id_rol1");

                    b.Navigation("id_rol");
                });

            modelBuilder.Entity("Backend.Models.Contacto", b =>
                {
                    b.Navigation("contactos");
                });

            modelBuilder.Entity("Backend.Models.Criterio", b =>
                {
                    b.Navigation("evaluaciones");
                });

            modelBuilder.Entity("Backend.Models.DetalleRequisicion", b =>
                {
                    b.Navigation("cotizaciones");
                });

            modelBuilder.Entity("Backend.Models.Empresa", b =>
                {
                    b.Navigation("contactos");

                    b.Navigation("contratos");

                    b.Navigation("cotizaciones");

                    b.Navigation("evaluaciones");

                    b.Navigation("img_establecimientos");
                });

            modelBuilder.Entity("Backend.Models.Establecimiento", b =>
                {
                    b.Navigation("img_establecimientos");
                });

            modelBuilder.Entity("Backend.Models.Perfil", b =>
                {
                    b.Navigation("directores");
                });

            modelBuilder.Entity("Backend.Models.Permiso", b =>
                {
                    b.Navigation("privilegios");
                });

            modelBuilder.Entity("Backend.Models.Producto", b =>
                {
                    b.Navigation("detalles");
                });

            modelBuilder.Entity("Backend.Models.Requisicion", b =>
                {
                    b.Navigation("detalles");
                });

            modelBuilder.Entity("Backend.Models.Usuario", b =>
                {
                    b.Navigation("contratos");

                    b.Navigation("directores");

                    b.Navigation("privilegios");
                });
#pragma warning restore 612, 618
        }
    }
}
