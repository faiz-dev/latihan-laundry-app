﻿using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;database=laundryDB;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PrePaidPackage> PrePaidPackages { get; set; }
        public DbSet<HeaderDeposit> HeaderDeposits { get; set;}
        public DbSet<DetailDeposit> DetailDeposits { get; set; }
    }
}
