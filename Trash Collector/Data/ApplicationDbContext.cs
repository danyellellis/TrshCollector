using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trash_Collector;

namespace Trash_Collector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                });
        }
        public DbSet<Trash_Collector.Models.Customer> Customer { get; set; }
        public DbSet<Trash_Collector.Models.Employee> Employees { get; set; }

    }
}
