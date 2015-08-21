namespace WCFNavigationPropertyMapping.Lib.EntityFrameworkModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LeaguesDataContext : DbContext
    {
        public LeaguesDataContext()
            : base("name=LeaguesConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<League>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.League)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);
        }
    }
}
