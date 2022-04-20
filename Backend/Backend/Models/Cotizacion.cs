using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Cotizacion
    {

        [Key]
        public int id_cotizacion { get; set; }

        [Column(TypeName = "varchar=17")]
        [StringLength(17, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "NIT")]
        public string? nit { get; set; }

        [Required]
        [Display(Name = "Fecha de requisicíón")]
        public DateTime? fecha { get; set; }

        public Empresa? empresa{ get; set; }
        public DetalleRequisicion? id_detalle { get; set; }
        public CondicionEconomica? id_condicion { get; set; }
    }
}
