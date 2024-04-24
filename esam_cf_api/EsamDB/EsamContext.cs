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
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaUser> AreaUsers { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Project>().ToTable("Projects").HasOne(p=>p.Category).WithMany(c=>c.Projects).HasForeignKey(p=>p.CategoryId);
            modelBuilder.Entity<Category>().ToTable("Categories");
            
        }
    }
}