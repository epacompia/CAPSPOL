using CAPSPOL.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<PoliceStation> PoliceStations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grade>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Speciality>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<PoliceStation>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
