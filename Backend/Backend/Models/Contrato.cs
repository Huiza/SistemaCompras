using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Contrato
    {

        [Key]
        public int id_contrato{ get; set; }

        public Empresa? empresa { get; set; }
        public Usuario? id_usuario { get; set; }
    }
}
