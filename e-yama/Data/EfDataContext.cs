using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using e_yama.Areas.Identity.Data;
using e_yama.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_yama.Data
{
    public class EfDataContext : IdentityDbContext
    {
        public EfDataContext(DbContextOptions<EfDataContext> options)
        : base(options)
        {
        }
        public DbSet<Address> Addres { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
