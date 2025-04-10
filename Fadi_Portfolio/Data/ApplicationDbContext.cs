using Fadi_Portfolio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fadi_Portfolio.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProImage> ProImages { get; set; }
        public DbSet<ProTech> ProTechs { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Service> Services { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }
    }
}
