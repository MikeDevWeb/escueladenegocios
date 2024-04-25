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

            modelBuilder.Entity<User>().ToTable("Users")
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Project>().ToTable("Projects")
                .HasOne(p=>p.Category)
                .WithMany(c=>c.Projects)
                .HasForeignKey(p=>p.CategoryId);

            modelBuilder.Entity<Area>().ToTable("Areas");

            modelBuilder.Entity<Role>().ToTable("Roles");

            modelBuilder.Entity<Project>().ToTable("Projects")
                .HasOne(p => p.Area)
                .WithMany(a => a.Projects)
                .HasForeignKey(p => p.AreaId);

            modelBuilder.Entity<Category>().ToTable("Categories");

            modelBuilder.Entity<AreaUser>().ToTable("AreaUsers")
            .HasKey(au => new { au.AreaID, au.UserID });

            modelBuilder.Entity<AreaUser>()
                .HasOne(au => au.Area)
                .WithMany(a => a.AreaUsers)
                .HasForeignKey(au => au.AreaID);

            modelBuilder.Entity<AreaUser>()
                .HasOne(au => au.User)
                .WithMany(u => u.AreaUsers)
                .HasForeignKey(au => au.UserID);

        }
    }
}