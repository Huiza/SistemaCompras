using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Establecimiento
    {
        public Establecimiento()
        {
            img_establecimientos = new HashSet<ImagenEstablecimiento>();
        }

        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre del establecimiento")]
        public string? nombre { get; set; }

        public virtual ICollection<ImagenEstablecimiento> img_establecimientos { get; set; }
    }
}
