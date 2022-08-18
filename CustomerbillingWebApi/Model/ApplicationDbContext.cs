using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerbillingWebApi.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Items> Items { get; set; }

        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Invoiceitems> Invoiceitems { get; internal set; }
    }
}
