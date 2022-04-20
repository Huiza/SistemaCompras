
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Privilegio
    {
        [Key]
        public int id_privilegio { get; set; }
        public Permiso? id_permiso { get; set; }
        public Usuario? id_usuario { get; set; }
    }
}
