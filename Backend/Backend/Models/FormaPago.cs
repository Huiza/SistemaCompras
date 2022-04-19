using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class FormaPago
    {
        [Key]
        public int id_pago { get; set; }

        [Column(TypeName = "varchar=100")]
        [Display(Name = "Forma de pago")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? tipo { get; set; }

    }
}