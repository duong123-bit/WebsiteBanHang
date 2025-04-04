﻿
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebsiteBanHang3.Models;
namespace WebsiteBanHang3.Models
{
    

public class ApplicationDbContext : IdentityDbContext<ApplicationUser
    >
    {
        public
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
    base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
         public DbSet<Order> Orders { get; set; } 
    public DbSet<OrderDetail> OrderDetails { get; set; } 
    }
}
