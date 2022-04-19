using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Contacto
    {
        public Contacto()
        {
            contactos = new HashSet<AgendaTelefonica>();
        }
        [Key]
        public int? id_contacto{ get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [Display(Name = "Nombre contacto")]
        [StringLength(150, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar=9")]
        [StringLength(9, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Teléfono")]
        public string? telefono { get; set; }

        public virtual ICollection<AgendaTelefonica> contactos { get; set; }

    }
}
