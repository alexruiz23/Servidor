using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploBBDDEF.Models
{
    [Table("Alumnos")]
    public class Alumno
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int IdAlumno { get; set; }

        [Required]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Key]
        [Required]
        [Column("DNI")]
        public string DNI {  get; set; }

        [Required]
        [Column("ciclo")]
        public string CicloAlumno {  get; set; }

        [Required]
        [Column("curso")]
        public int CursoAlumno { get; set; }
    }

}
