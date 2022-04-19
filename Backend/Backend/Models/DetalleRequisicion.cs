using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class DetalleRequisicion
    {
        public DetalleRequisicion()
        {
            cotizaciones = new HashSet<Cotizacion>();
        }
        [Key]
        public int id_detalle { get; set; }
        public int id_producto { get; set; }
        public int id_requisicion { get; set; }
        public int cantidad { get; set; }
        public Producto? producto { get; set; }
        public Usuario? usuario { get; set; }
        public Requisicion? requisicion { get; set; }
        public virtual ICollection<Cotizacion> cotizaciones { get; set; }

    }
}
