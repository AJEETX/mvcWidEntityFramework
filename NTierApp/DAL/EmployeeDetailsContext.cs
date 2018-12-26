using NTierApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTierApp.DAL
{
    public class EmployeeDetailsDbContext : DbContext
    {
        public EmployeeDetailsDbContext() : base("MyConnection")
        {
        }

        public DbSet<EmployeeDetails> employeeDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}