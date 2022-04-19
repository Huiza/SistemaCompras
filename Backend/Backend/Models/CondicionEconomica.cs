using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class CondicionEconomica
    {
        [Key]
        public int id_condicion { get; set; }

        [Required]
        [Display(Name = "Precio de los envases")]
        public double? precio_envases { get; set; }

        [Required]
        [Display(Name = "Precio de embalajes")]
        public double? precio_embalajes { get; set; }

        [Required]
        [Display(Name = "Pago transporte")]
        public double? pago_transporte { get; set; }

        [Required]
        [Display(Name = "Recargo aplazamiento")]
        public double? recargo_aplazamiento { get; set; }
        public PlazoPago? id_plazo { get; set; }
        public DescuentoComercial? id_descuento { get; set; }
        public FormaPago? id_pago { get; set; }


    }
}