using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        [Required]
        [Column("id")]
        public int idGenero { get; set; }

        [Required]
        [Column("genero")]
        public string genero { get; set; }

    }
}
