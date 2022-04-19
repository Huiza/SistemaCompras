using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Requisicion
    {
        public Requisicion()
        {
            detalles = new HashSet<DetalleRequisicion>();
        }
        [Key]
        public int id_detalle{ get; set; }

        [Required]
        [Display(Name = "Fecha de requisicíón")]
        public DateTime? fecha { get; set; }

        [Required]
        [Display(Name = "Prioridad")]
        public string? prioridad { get; set; }

        [Required]
        [Display(Name = "Fecha estimada")]
        public DateTime? fecha_estimada { get; set; }
        public virtual ICollection<DetalleRequisicion> detalles{ get; set; }
    }
}
