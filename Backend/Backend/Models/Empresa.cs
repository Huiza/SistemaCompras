using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Empresa
    {
        public Empresa()
        {
            contactos = new HashSet<AgendaTelefonica>();
            cotizaciones = new HashSet<Cotizacion>();
            evaluaciones = new HashSet<Evaluacion>();
        }

        [Key]
        [Column(TypeName = "varchar=17")]
        [StringLength(17, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "NIT")]
        public string? nit { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50,ErrorMessage ="El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Representante legal")]
        public string? nombre_representante { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Dirección")]
        public string? direccion { get; set; }

        [Required]
        [Column(TypeName = "varchar=9")]
        [StringLength(9, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Teléfono")]
        public string? telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar=9")]
        [StringLength(9, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Fax")]
        public string? Fax { get; set; }

        [Required]
        [Column(TypeName = "varchar=9")]
        [StringLength(9, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Teléfono móvil")]
        public string? telefonoMovil { get; set; }

        [Required]
        [Column(TypeName = "varchar=150")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Dirección electrónica")]
        public string? email { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [StringLength(50, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Sitio web")]
        public string? website { get; set; }

        [Required]
        [Column(TypeName = "varchar=17")]
        [StringLength(17, ErrorMessage = "El {0} debe ser máximo {1} carácteres")]
        [Display(Name = "Número de Registro de Contribuyente(NRC)")]
        public string? Nrc { get; set; }

        [Required]
        [Column(TypeName = "varchar=100")]
        [Display(Name = "Número de años o rubro")]
        public int? rubro { get; set; }

        [Required]
        [Column(TypeName = "varchar=5")]
        [Display(Name = "Número de años o rubro")]

        public Perfil? id_perfil { get; set; }

        public TipoEmpresa? id_tipo_empresa { get; set; }

        public virtual ICollection<AgendaTelefonica>contactos { get; set; }
        public virtual ICollection<Cotizacion> cotizaciones { get; set; }
        public virtual ICollection<Evaluacion> evaluaciones{ get; set; }
    }
}
