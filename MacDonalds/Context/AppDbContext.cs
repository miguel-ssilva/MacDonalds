using MacDonalds.Models;
using Microsoft.EntityFrameworkCore;

namespace MacDonalds.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        // Já estamos a definir o nome das tabelas em SQL ("Categorias" e "Lanches")
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }
    }
}
