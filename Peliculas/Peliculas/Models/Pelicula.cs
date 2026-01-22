using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Models
{
    [Table("Peliculas")]
    public class Pelicula
    {
        [Key]
        [Required]
        [Column("id")]
        public int idPelicula { get; set; }

        [Required]
        [Column("titulo")]
        public string tituloPelicula { get; set; }

        [Required]
        [Column("fecha")]
        public string fechaPelicula { get; set; }


        [Required]
        [Column("genero")]
        public string generoPelicula { get; set; }


        [Required]
        [Column("precio")]
        public int precioPelicula { get; set; }

    }
}
