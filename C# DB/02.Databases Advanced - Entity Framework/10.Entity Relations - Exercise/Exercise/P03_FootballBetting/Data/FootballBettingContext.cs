using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;
using System.Reflection;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            : base (options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder bulder)
        {
            if (!bulder.IsConfigured)
            {
                bulder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FootballBetting;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Team>()
               .Property(t => t.Name)
               .IsRequired(true)
               .IsUnicode(true)
               .HasMaxLength(50);

            builder.Entity<Team>()
               .Property(t => t.LogoUrl)
               .IsRequired(true)
               .IsUnicode(false);


            builder.Entity<Team>()
               .Property(t => t.Initials)
               .IsRequired(true)
               .IsUnicode(true)
               .HasMaxLength(3);

            builder.Entity<Team>()
               .HasOne(t => t.PrimaryKitColor)
               .WithMany(pkc => pkc.PrimaryKitTeams)
               .HasForeignKey(t => t.PrimaryKitColorId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Team>()
               .HasOne(t => t.SecondaryKitColor)
               .WithMany(pkc => pkc.SecondaryKitTeams)
               .HasForeignKey(t => t.SecondaryKitColorId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Team>()
                .HasOne(t => t.Town)
                .WithMany(town => town.Teams)
                .HasForeignKey(t => t.TownId);

            builder.Entity<Color>(c =>
            {
                c.Property(c => c.Name)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(30);

            });

            builder.Entity<Town>(t =>
            {
                t.Property(t => t.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(50);


            });

            builder.Entity<Town>()
                .HasOne(t => t.Country)
                .WithMany(c => c.Towns)
                .HasForeignKey(t => t.CountryId);

            builder.Entity<Country>()
                .Property(c => c.Name)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(50);


            builder.Entity<Game>(g =>
            {
                g.Property(g => g.Result)
                .IsRequired(false)
                .IsUnicode(false)
                .HasMaxLength(10);
            });

            builder.Entity<Game>()
                .HasOne(g => g.HomeTeam)
                .WithMany(ht => ht.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Game>()
                .HasOne(g => g.AwayTeam)
                .WithMany(at => at.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Player>(p =>
            {
                p.Property(p => p.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                p.
                HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId);

                p
                .HasOne(p => p.Position)
                .WithMany(pos => pos.Players)
                .HasForeignKey(p => p.PositionId);
            });

            builder.Entity<Position>()
                .Property(p => p.Name)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(20);

            builder.Entity<PlayerStatistic>(ps =>
            {
                ps.HasKey(ps => new { ps.PlayerId, ps.GameId });

                ps
                .HasOne(ps => ps.Player)
                .WithMany(p => p.PlayerStatistics)
                .HasForeignKey(ps => ps.PlayerId);

                ps
                .HasOne(ps => ps.Game)
                .WithMany(g => g.PlayerStatistics)
                .HasForeignKey(ps => ps.GameId);
            });


            builder.Entity<Bet>(b =>
            {
                b
                .HasOne(b => b.User)
                .WithMany(u => u.Bets)
                .HasForeignKey(b => b.UserId);

                b
                .HasOne(b => b.Game)
                .WithMany(g => g.Bets)
                .HasForeignKey(b => b.GameId);
            });

            builder.Entity<User>(u =>
            {
                u.Property(u => u.Username)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(50);

                u.Property(u => u.Password)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(256);

                u.Property(u => u.Email)
                .IsRequired(true)
                .IsUnicode(false)
                .HasMaxLength(50);

                u.Property(u => u.Name)
                .IsRequired(false)
                .IsUnicode(true)
                .HasMaxLength(80);
            });
        }
    }
}