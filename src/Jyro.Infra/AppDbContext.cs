using Jyro.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;


namespace Jyro.Infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Core.Entities.Task> Tasks { get; set; }
        public DbSet<Time> Times { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasMany(u => u.CommentariesWrote).WithOne(c => c.Author);
                user.HasMany(u => u.CommentaryMentionned).WithMany(c => c.Mentionned);
            });
        }
    }
}
