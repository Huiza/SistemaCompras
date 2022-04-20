using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Referencia
    {

        [Key]
        public int id_referencia { get; set; }
        public double valor_negocio { get; set; }
        public AgendaTelefonica? id_agenda { get; set; }
    }
}

