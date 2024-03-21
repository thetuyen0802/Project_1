using _3.DAL.Configuration;
using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Du_An_1_Ban_Quan_Ao;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BillConfig());
            modelBuilder.ApplyConfiguration(new Bill_ProductDetailConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ColorConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new EmployessConfig());
            modelBuilder.ApplyConfiguration(new Event_ProductConfig());
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new ImageConfig());
            modelBuilder.ApplyConfiguration(new MaterialConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductDetailConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new SizeConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

            
        }
       
        public virtual DbSet<Bill>? Bills { get; set; }
        public virtual DbSet<Bill_ProductDetail>? Bill_ProductDetails { get; set; }
        public virtual DbSet<Brand>? Brands { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<Color>? Colors { get; set; }
        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<Employess>? Employesses { get; set; }
        public virtual DbSet<Event_Product>? Event_Products { get; set; }
        public virtual DbSet<Event>? Events { get; set; }
        public virtual DbSet<Image>? Images { get; set; }
        public virtual DbSet<Material>? Materials { get; set; }
        public virtual DbSet<Product>? Products { get; set; }
        public virtual DbSet<ProductDetail>? ProductDetails { get; set; }
        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<Size>? Sizes { get; set; }
        public virtual DbSet<User>? Users { get; set; }




    }
}
