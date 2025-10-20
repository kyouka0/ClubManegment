using ClubManegment.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubManegment.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet <Player> Player { get; set; }
        public DbSet<Coach> coaches { get; set; }
        public DbSet<Competition> competitions { get; set; }
         public DbSet<Team> teams {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasOne(x => x.Coach).WithOne(x => x.Team).HasForeignKey<Team>(x => x.CoachId);

            modelBuilder.Entity<Team>().HasMany(x => x.Players).WithOne(x => x.Team);
            modelBuilder.Entity<Team>().HasMany(x => x.Competition).WithMany(x => x.Team);

            
        }

      
    }
}
