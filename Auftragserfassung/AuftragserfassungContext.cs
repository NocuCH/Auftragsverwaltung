using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    class AuftragserfassungContext : DbContext
    {
        private static AuftragserfassungContext instance;
        public static AuftragserfassungContext Instance { 
            get {
                if (instance == null) {
                    instance = new AuftragserfassungContext();
                }
                return instance;
            } 
            private set { instance = value; }
        }
        public DbSet<Kunde> Kunden {  get; set; }
        public DbSet<Artikelgruppe> Artikelgruppen { get; set; }
        public DbSet<Artikel> Artikel { get; set; }
        public DbSet<Auftrag> Auftraege { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=.\\ZBW; Database=Auftragserfassung; Trusted_Connection=True; Encrypt=False");

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Artikelgruppe>()
                .HasOne(x => x.Parent)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder
                //.Entity<Kunde>()
                //.ToTable("Kunde", b => b.IsTemporal());
        }

    }
}
