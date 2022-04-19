
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Rol
    {
        [Key]
        public int id_rol { get; set; }

        [Column(TypeName = "varchar=100")]
        [Display(Name = "Nombre del rol")]
        [StringLength(25, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? nombre { get; set; }

    }
}
