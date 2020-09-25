using Microsoft.EntityFrameworkCore;
using MiguelBeneditProgramacion3_Core.Entities;
using System.IO.Compression;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework
{
    public class DBEmpireContext : DbContext
    {
        public DbSet<Empire> Empires { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ground> Grounds { get; set; }
        public DbSet<Heroe> Heroes { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<EntityBase>();

            modelBuilder.Entity<User>(u => u.HasKey(u => u.Id));

            modelBuilder.Entity<Game>(g =>
            {
                g.HasOne(g => g.Map);

                g.HasMany(g => g.Empires);
            });

            modelBuilder.Entity<Empire>(e =>
            {
                e.HasMany(e => e.Cities)
                .WithOne(e => e.Empire)
                .HasForeignKey(e => e.EmpireId)
                .IsRequired();

                e.HasMany(e => e.Heroes)
                .WithOne(e => e.Empire)
                .HasForeignKey(e => e.EmpireId)
                .IsRequired();

                e.Property(e => e.Race)
                .IsRequired();

                e.Property(e => e.Name)
                .IsRequired();
            });
        }
    }
}
