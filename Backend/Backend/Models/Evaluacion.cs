using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Evaluacion
    {

        [Key]
        public int id_evaluacion { get; set; }

        public int id_criterio { get; set; }
        public int nit { get; set; }
        public int nota { get; set; }
        public Criterio? criterio { get; set; }
        public Empresa? empresa { get; set; }
    }
}

