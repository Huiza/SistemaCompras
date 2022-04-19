using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class DescuentoComercial
    {
        [Key]
        public int id_descuento { get; set; }

        [Column(TypeName = "varchar=100")]
        [Display(Name = "Nombre descuento comercial")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? nombre{ get; set; }

    }
}
