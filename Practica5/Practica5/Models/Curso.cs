using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica5.Models
{
    [Table("Cursos")]
    public class Curso
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int IdCurso { get; set; }

        [Required]
        [Column("Curso")]
        public int NumeroCurso { get; set; }

        [Required]
        [Column("aula")]
        public string AulaCiclo { get; set; }

        [Required]
        [Column("ciclo")]
        public string CicloCurso { get; set; }
    }
}
