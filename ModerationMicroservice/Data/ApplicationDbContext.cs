using Microsoft.EntityFrameworkCore;
using ModerationMicroservice.Entities;

namespace ModerationMicroservice.Data
{
    public class ModerationContext : DbContext
    {
        public ModerationContext(DbContextOptions<ModerationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Moderation> Moderations { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<ModerationArchive> ModerationArchives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specify The Schema
            modelBuilder.Entity<User>().ToTable("Users", "CWR2");
            modelBuilder.Entity<Role>().ToTable("Roles", "CWR2");
            modelBuilder.Entity<UserRole>().ToTable("UserRoles", "CWR2");
            modelBuilder.Entity<Moderation>().ToTable("Moderations", "CWR2");
            modelBuilder.Entity<Email>().ToTable("Emails", "CWR2");
            modelBuilder.Entity<ModerationArchive>().ToTable("ModerationArchives", "CWR2");

            // UserRoles configuration
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => ur.UserRoleID);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserID);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleID);

            // Moderation configuration
            modelBuilder.Entity<Moderation>()
                .HasKey(m => m.ModerationID);

            modelBuilder.Entity<Moderation>()
                .HasOne(m => m.User)
                .WithMany(u => u.Moderations)
                .HasForeignKey(m => m.UserID);

            // Email configuration
            modelBuilder.Entity<Email>()
                .HasKey(e => e.EmailID);

            modelBuilder.Entity<Email>()
                .HasOne(e => e.User)
                .WithMany(u => u.Emails)
                .HasForeignKey(e => e.UserID);
        }
    }
}
