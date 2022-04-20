
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Permiso
    {
        public Permiso()
        {
            privilegios = new HashSet<Privilegio>();
        }
        [Key]
        public int id_permiso { get; set; }

        [Column(TypeName = "varchar=100")]
        [Display(Name = "Nombre del permiso")]
        [StringLength(25, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        public string? nombre { get; set; }
        public virtual ICollection<Privilegio> privilegios { get; set; }

    }
}
