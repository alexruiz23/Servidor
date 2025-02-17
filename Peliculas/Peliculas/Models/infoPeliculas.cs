using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Models
{
    [Table("infoPeliculas")]
    public class infoPeliculas
    {
        [Key]
        [Required]
        [Column("id")]
        public int idPelicula { get; set; }

        [Required]
        [Column("director")]
        public string directorPelicula { get; set; }

        [Required]
        [Column("sinopsis")]
        public string sinopsis { get; set; }


        [Required]
        [Column("actor")]
        public string actorPelicula { get; set; }


        [Required]
        [Column("actriz")]
        public string actriz{ get; set; }

    }
}
