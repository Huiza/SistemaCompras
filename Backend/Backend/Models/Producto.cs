using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Producto
    {
        public Producto()
        {
            detalles = new HashSet<DetalleRequisicion>();
        }
        [Key]
        public string? id_producto{ get; set; }

        [Required]
        [Display(Name = "Precio")]
        public double? precio { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Marca")]
        public string? marca { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Característica")]
        public string? caracteristica { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Medida")]
        public string? medida { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Color")]
        public string? color { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Utilidad")]
        public string? utilidad { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Garantía")]
        public string? garantia { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(1, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Imagen")]
        public string? imagen { get; set; }

        public TipoProducto? id_tipo_producto{ get; set; }

        public Categoria? id_categoria{ get; set; }
        public virtual ICollection<DetalleRequisicion> detalles { get; set; }
    }
}
