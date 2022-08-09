using SistemaChamado.Data.Mappings;
using SistemaChamado.Models;
using Microsoft.EntityFrameworkCore;
using SistemaChamado.Models;

namespace SistemaChamado.Data
{
    public class SistemaChamadoDataContext : DbContext
    {
        public SistemaChamadoDataContext(DbContextOptions<SistemaChamadoDataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}