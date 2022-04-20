using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ImagenEstablecimiento
    {

        [Key]
        public int id_imagen { get; set; }

        public string? nit { get; set; }
        public int? id_establecimiento {get;set;}

        [Required]
        [Display(Name = "Imagen del establecimiento")]
        public string? imagen_establecimiento { get; set; }

        public Empresa? empresa { get; set; }
        public Establecimiento? establecimiento { get; set; }
    }
}
