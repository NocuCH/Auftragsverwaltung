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
        public DbSet<Kunde> Kunden {  get; set; }
        public DbSet<Artikelgruppe> Artikelgruppen { get; set; }
        public DbSet<Artikel> Artikel { get; set; }
        public DbSet<Auftrag> Auftraege { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=.\\DB; Database=Auftragserfassung; Trusted_Connection=True; Encrypt=False");

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .Entity<Kunde>()
                .ToTable("Kunde", b => b.IsTemporal());
        }

    }
}
