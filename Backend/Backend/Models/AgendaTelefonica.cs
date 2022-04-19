using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class AgendaTelefonica
    {
        [Key]
        public int id_agenda { get; set; }
        public int nit{ get; set; }
        public int id_contacto { get; set; }
        public Contacto? contacto { get; set; }
        public Empresa? empresa { get; set; }

    }
}
