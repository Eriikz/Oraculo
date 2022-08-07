using Microsoft.EntityFrameworkCore;

namespace Oraculo.Api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {

        }

        public DbSet<Theft> Theft { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=Oraculo;Pooling=true;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theft>().
                HasKey(PE => new { PE.Num_bo });
            base.OnModelCreating(modelBuilder);
        }
    }
}
