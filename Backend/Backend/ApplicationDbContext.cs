using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<AgendaTelefonica> AgendaTelefonica { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<CondicionEconomica> condicion_economica { get; set; }
        public DbSet<Contacto> contacto { get; set; }
        public DbSet<Contrato> contrato { get; set; }
        public DbSet<Cotizacion> cotizacion { get; set; }
        public DbSet<Criterio> criterio { get; set; }
        public DbSet<DescuentoComercial>desceunto_comercial { get; set; }
        public DbSet<DetalleRequisicion>detalle_requisicion { get; set;}
        public DbSet<DireccionGeneral>direccion_general { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Establecimiento> establecimiento { get; set; }
        public DbSet<Evaluacion> evaluacion { get; set; }
        public DbSet<FormaPago> forma_pago { get; set; }
        public DbSet<ImagenEstablecimiento> img_establecimiento { get; set; }
        public DbSet<Inventario> inventario { get; set; }
        public DbSet<Perfil> perfil { get; set; }
        public DbSet<Permiso> permiso { get; set; }
        public DbSet<PlazoPago> plazo_pago { get; set; }
        public DbSet<Privilegio> privilegio { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Referencia> referencia { get; set; }
        public DbSet<Requisicion> requisicion { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<TipoEmpresa> tipo_empresa { get; set; }
        public DbSet<TipoProducto> tipo_producto { get; set; }
        public DbSet<Usuario> usuario { get; set; }


    }
}
