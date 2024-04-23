using Microsoft.EntityFrameworkCore;

namespace EsamDB
{
    public class EsamContext :DbContext
    {
        public EsamContext(DbContextOptions<EsamContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");

        }
    }
}
