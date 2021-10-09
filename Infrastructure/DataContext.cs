using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infastructure
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<FrontEndSkills>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<BackEndSkills>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Images>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id = Guid.NewGuid(),
                    FullName = "Muath Alobaisi",
                    Profil = "Software Developer / Fullstack Developer"
                }
                );
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<FrontEndSkills> FrontEndSkills { get; set; }
        public DbSet<BackEndSkills> BackEndSkills { get; set; }
        public DbSet<Images> Images { get; set; }


    }
}
