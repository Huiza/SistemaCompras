using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Perfil
    {
        [Key]
        public int id_perfil { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Escrituras")]
        public string? escrituras { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Razón Social")]
        public string? razon_social { get; set; }

        [Required]
        [Display(Name = "Sucursal")]
        public bool sucursal { get; set; }

        [Required]
        [Column(TypeName = "varchar=1")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Calificación")]
        public string? calificacion { get; set; }
    }
}
