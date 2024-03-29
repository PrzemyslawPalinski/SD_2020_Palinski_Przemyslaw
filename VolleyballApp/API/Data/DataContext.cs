using VolleyballApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace VolleyballApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Friendlist> Friendlist { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<TeamLeague> TeamLeague { get; set; }
        public DbSet<UserTeam> UserTeam { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Message>()
            .HasOne(u => u.Sender)
            .WithMany(u => u.MessagesSent)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
            .HasOne(u => u.Recipient)
            .WithMany(u => u.MessagesReceived)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Photo>()
            .HasOne(u => u.User)
            .WithOne(u => u.Photo)
            .IsRequired(false);

            modelBuilder.Entity<Photo>()
            .HasOne(u => u.Team)
            .WithOne(u => u.Photo)
            .IsRequired(false);

            modelBuilder.Entity<TeamLeague>()
            .HasKey( x => new {x.LeagueId, x.TeamId});

            modelBuilder.Entity<UserTeam>()
            .HasKey( x => new {x.UserId, x.TeamId});

            modelBuilder.Entity<League>()
            .HasMany(x => x.Matches)
            .WithOne(x => x.League);
        }
    }
}