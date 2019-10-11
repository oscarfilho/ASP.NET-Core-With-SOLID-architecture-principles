﻿using System;
using System.Collections.Generic;
using System.Text;
using eCommerce.DatabaseContext.FluentApiConfiguration;
using eCommerceApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DatabaseContext
{
    public class DatabaseDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies(false)
                .UseSqlServer("Server=(local);Database=eCommerceApp_Auth;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductFluentApiConfigure());
            modelBuilder.ApplyConfiguration(new CategoryFluentApiConfigure());
            modelBuilder.Entity<Product>().HasQueryFilter(p => p.IsActive);
        }
    }
}