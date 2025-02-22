using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Context
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos => Set<Produto>();
    }
}
