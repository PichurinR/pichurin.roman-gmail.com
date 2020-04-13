using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBApp;Trusted_Connection=True;");
        }
    }
}
