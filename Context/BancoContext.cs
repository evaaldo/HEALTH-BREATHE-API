using HealthBreath.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthBreath.Context.BancoContext
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Dieta> Dietas { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}