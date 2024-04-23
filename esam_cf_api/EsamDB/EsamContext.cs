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
            /// <summary>
            /// Configures the model that was discovered by convention from the entity types
            /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on the derived context.
            /// </summary>
            /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
                   
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<Category>().ToTable("Categories");
                   

        }
    }
}
