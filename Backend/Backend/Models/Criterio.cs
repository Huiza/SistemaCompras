using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Criterio
    {
        public Criterio()
        {
            evaluaciones = new HashSet<Evaluacion>();
        }
        [Key]
        public int? id_criterio{ get; set; }

        [Required]
        [Display(Name = "Nombre del criterio")]
        public string? nombre { get; set; }
        public virtual ICollection<Evaluacion>evaluaciones{ get; set; }

    }
}
