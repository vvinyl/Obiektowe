using Microsoft.EntityFrameworkCore;
using App.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace App
{
    public class AppDbContext : DbContext
    {
        public DbSet<Article> Articles {get; set;}
        public DbSet<Author>  Authors{get; set;}
        public DbSet<Category> Categories{get; set;}
        public DbSet<Comment> Comments{get; set;}
        public DbSet<EventType> EventTypes {get; set;}
        public DbSet<League> Leagues {get; set;}
        public DbSet<Match> Matches {get; set;}
        public DbSet<MatchEvent> MatchEvents {get; set;}
        public DbSet<MatchPlayer> MatchPlayers {get; set;}
        public DbSet<Player> Players {get; set;}
        public DbSet<Position> Positions {get; set;}
        public DbSet<Tag> Tags {get; set;}
        public DbSet<Team> Teams {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(y => y.HomeMatches)
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Match>()
                .HasOne(x => x.AwayTeam)
                .WithMany(y => y.AwayMatches)
                .HasForeignKey(x => x.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
