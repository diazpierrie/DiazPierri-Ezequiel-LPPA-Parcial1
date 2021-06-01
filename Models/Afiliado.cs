using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiazPierri_Ezequiel_LPPA_Parcial1.Models
{
    [Table("Afiliados")]
    public class Afiliado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(13)]
        public string CUIT { get; set; }
    }
}