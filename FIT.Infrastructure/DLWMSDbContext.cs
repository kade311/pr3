using FIT.Data;

using Microsoft.EntityFrameworkCore;

using System.Configuration;
using FIT.Data.Jan24;
using FIT.Data.Feb24;
using Microsoft.EntityFrameworkCore.Internal;
using FIT.Data.Jul24;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Drzave> Drzave { get; set; }
        public DbSet<Gradovi> Gradovi { get; set; }
        public DbSet<PolozeniPredmeti> PolozeniPredmeti { get; set; }
        public DbSet<Prostorije> Prostorije { get; set; }
        public DbSet<Nastava> Nastava { get; set; }
        public DbSet<Prisustvo> Prisustvo { get; set; }
        public DbSet<Predmeti> Predmeti { get; set; }
        public DbSet<StudentiUvjerenja> StudentiUvjerenja { get; set; }

    }
}