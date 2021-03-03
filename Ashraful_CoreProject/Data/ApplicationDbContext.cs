using System;
using System.Collections.Generic;
using System.Text;
using Ashraful_CoreProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ashraful_CoreProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<OrderMast> OrderMasts { get; set; }
        public DbSet<OrderDetl> OrderDetls { get; set; }

        public DbSet<ProductAjax> ProductAjaxes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Registration> Registrations { get; set; }
    }
}
