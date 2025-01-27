﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploBBDDEF.Models
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
        [Column("curso")]
        public int CursoCiclo {  get; set; }

        [Required]
        [Column("aula")]
        public string Aula { get; set; }

        [Required]
        [Column("ciclo")]
        public string CicloCurso { get;set; }
    }
}
