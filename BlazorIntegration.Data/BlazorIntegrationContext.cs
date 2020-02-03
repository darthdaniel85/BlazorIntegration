using System;
using System.Collections.Generic;
using System.Text;
using BlazorIntegration.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorIntegration.Data
{
    public class BlazorIntegrationContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-DT04KQQ\\SQLEXPRESS;Database=BlazorIntegration;User Id=sa;password=SQLAdmin2019;Trusted_Connection=False;MultipleActiveResultSets=true;");
        }
    }
}
