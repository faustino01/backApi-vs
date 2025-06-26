using backApi_vs.Entidades;
using Microsoft.EntityFrameworkCore;

namespace backApi_vs
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
    }
}
