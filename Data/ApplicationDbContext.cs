using Microsoft.EntityFrameworkCore;
using ContaLuz.Domain;

namespace ContaLuz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
            
        public DbSet<Conta> Contas { get; set; }
    }
}