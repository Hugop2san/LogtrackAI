using LogtrackAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogtrackAI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //instncias
        
        public DbSet<Entrega> EntregaDB { get; set; }
        public DbSet<Motorista> MotoristaDB { get; set; }
        public DbSet<Rota> RotaDB { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }

    }
}
