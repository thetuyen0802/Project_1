using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Configuration
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable("ProductDetails");
            builder.HasKey(x => x.ProDetailId);
            builder.Property(a=>a.ProDetailId).UseIdentityColumn(1,1);
            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.Brand).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.BrandId);
            builder.HasOne(x=>x.Material).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.MaterialId);
            builder.HasOne(x => x.Color).WithMany(x => x.ProductDetails).HasForeignKey(x => x.ColorId);
            builder.HasOne(x=>x.Size).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.SizeId);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductDetails).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x=>x.Image).WithMany(x=>x.ProductDetails).HasForeignKey(x=>x.ImageId);
        }
    }
}
