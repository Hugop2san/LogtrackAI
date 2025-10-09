using LibraryFlow.Domain.Entities;
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
        //ex.
        // public DbSet<Book> Books { get; set; }
    }
}
