using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using TreinamentoWebAPI.Domain;

namespace TreinamentoWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SuperHeroi> SuperHerois { get; set; }
        public DbSet<Poder> Poderes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog = TreinamentoWebAPIdb; Integrated Security=true;");
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
