using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Usuario
    {
        public Usuario()
        {
            directores = new HashSet<DireccionGeneral>();
            privilegios = new HashSet<Privilegio>();
            contratos = new HashSet<Contrato>();
        }
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [Display(Name = "Nombre de usuario")]
        [StringLength(150, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(150, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Email")]
        public string? email{ get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(150, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "password")]
        public string? password { get; set; }

        public Rol? id_rol { get; set; }
        public virtual ICollection<DireccionGeneral> directores { get; set; }
        public virtual ICollection<Privilegio> privilegios { get; set; }
        public virtual ICollection<Contrato> contratos { get; set; }

    }
}
