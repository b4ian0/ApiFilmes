using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFilmes.Models
{
    [Table("Filmes")]
    public class FilmesGs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string? Streaming { get; set; }
        public int Classificao { get; set; }
        public float? Avaliacao { get; set; }
        public string? Foto { get; set; }

        public string Status { get; set;}
    }
}
