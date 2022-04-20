using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class DireccionGeneral
    {

        [Key]
        public int id_direccion { get; set; }

        public int id_perfil { get; set; }
        public int id_usuario { get; set; }
        public Perfil? perfil{ get; set; }
        public Usuario? usuario { get; set; }
    }
}

