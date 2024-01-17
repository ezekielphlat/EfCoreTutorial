using EfCoreBasics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.;Initial Catalog=EfCoreBasics;User ID=sa;Password=P@ssw0rd;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>().HasKey(k => new {k.EmployeeId, k.ProjectId});
            modelBuilder.Entity<EmployeeProject>().HasOne(e => e.Employee).WithMany(p => p.EmployeeProjects).HasForeignKey(e => e.EmployeeId);
            modelBuilder.Entity<EmployeeProject>().HasOne(p => p.Project).WithMany(p => p.EmployeesProjects).HasForeignKey(p => p.ProjectId);
        }
    }
}
