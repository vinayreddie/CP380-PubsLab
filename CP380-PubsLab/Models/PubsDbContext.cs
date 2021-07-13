using System;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace CP380_PubsLab.Models
{
    public class PubsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\pubs.mdf"));
            optionsBuilder.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Integrated Security=true;AttachDbFilename={dbpath}");
        }

        // TODO: Add DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO
        }
    }


    public class Titles
    {
        // TODO
    }


    public class Stores
    {
        // TODO
    }


    public class Sales
    {
        // TODO
    }

    public class Employee
    {
        // TODO
    }

    public class Jobs
    {
        // TODO
    }
}
