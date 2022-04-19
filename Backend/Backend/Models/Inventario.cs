using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Inventario
    {
        [Key]
        public int id_inventario { get; set; }

        [Display(Name = "Existencia")]
        public int existencia { get; set; }


        [Display(Name = "Entrada")]
        public int entrada { get; set; }

        [Display(Name = "Salida")]
        public int salida { get; set; }

        public Producto? producto { get; set; }

    }
}

