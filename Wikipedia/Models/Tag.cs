namespace Wikipedia.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
