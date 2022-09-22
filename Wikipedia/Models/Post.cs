using System.ComponentModel.DataAnnotations;

namespace Wikipedia.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }


    }
}
