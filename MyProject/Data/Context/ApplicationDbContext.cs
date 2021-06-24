using Microsoft.EntityFrameworkCore;
using MyProject.Data.Configuration;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<Config>(t => { t.HasNoKey(); });

        }
    }
}