using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class TipoProducto
    {
        [Key]
        public string? id_tipo_producto { get; set; }

        [Column(TypeName = "varchar=100")]
        [StringLength(150, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Tipo de producto")]
        public string? nombre { get; set; }

    }
}
