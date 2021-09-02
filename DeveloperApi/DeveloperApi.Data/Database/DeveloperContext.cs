using System;
using DeveloperApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeveloperApi.Data.Database
{
    public class DeveloperContext : DbContext
    {
        public DeveloperContext()
        {
        }

        public DeveloperContext(DbContextOptions<DeveloperContext> options) : base(options)
        {
        }

        public DbSet<Developer> Developer { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>(entity =>
            {
                entity.Property(e => e.Id).HasDevaultValueSql("(newid())");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Position).IsRequired();
            });
        }

    }
}