using Microsoft.EntityFrameworkCore;
using react.Model;

namespace react.Context
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
