using Microsoft.EntityFrameworkCore;

namespace EsamDB
{
    public class EsamContext :DbContext
    {
        public EsamContext(DbContextOptions<EsamContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<Category>().ToTable("Categories");
                   

        }
    }
}
