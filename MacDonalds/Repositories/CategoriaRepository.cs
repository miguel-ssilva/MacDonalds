using MacDonalds.Context;
using MacDonalds.Models;
using MacDonalds.Repositories.Interfaces;

namespace MacDonalds.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
