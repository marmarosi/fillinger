using Microsoft.EntityFrameworkCore;

namespace Fillinger.Models
{
    public class ApplicationDbContext : DbContext
    {
        public string ConnectionString { get; set; } = "Server=(localdb)\\mssqllocaldb;Database=XE1RSV;Trusted_Connection=True;MultipleActiveResultSets=true";

        public ApplicationDbContext()
            : base()
        { }

        public ApplicationDbContext(
            string connectionString
            )
            : base()
        {
            ConnectionString = connectionString;
        }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
            )
            : base(options)
        { }

        public DbSet<Ember> Emberek { get; set; }
        public DbSet<Kapcsolat> Kapcsolatok { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
            )
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder
            )
        {
            modelBuilder.Entity<Kapcsolat>()
                .HasNoKey();
        }
    }
}
