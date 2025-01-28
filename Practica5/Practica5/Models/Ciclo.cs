

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Ciclos")]
    public class Ciclo
    {
        [Column("Codigo")]
        [Required]
        public string Codigo { get; set; }
        
        [Key]
        [Column("Siglas")]
        [Required]
        public string? Siglas { get; set; }

        [Column("Nombre")]
        [Required]
        public string? Nombre { get; set;}
       
        [Column("Cursos")]
        [Required]
        public int Numero_Cursos { get; set; }

    }
}
