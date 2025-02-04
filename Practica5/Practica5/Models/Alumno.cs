using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        [Required]
        [Column("DNI")]
        public string DNI { get; set; }

        [Required]
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Column("Apellidos")]
        public string Apellidos { get; set; }


        [Required]
        [Column("Telefono")]
        public string Telefono { get; set; }


        [Required]
        [Column("Edad")]
        public int Edad { get; set; }


        [Required]
        [Column("Ciclo")]
        public string CicloAlumno {  get; set; }

        [Required]
        [Column("Curso")]
        public int CursoAlumno { get; set; }

        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  idAlumno { get; set; }
    }

}
