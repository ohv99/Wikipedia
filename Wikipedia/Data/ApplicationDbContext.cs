using Microsoft.EntityFrameworkCore;
using Wikipedia.Models;

namespace Wikipedia.Data
{
    public class ApplicationDbContext :DbContext
    {
        //Sobreescribir constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Sobreescribir metodo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        //Vamos a decirle a EF Core las tablas que va a crear
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
