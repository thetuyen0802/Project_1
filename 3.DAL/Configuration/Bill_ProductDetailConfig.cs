using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Configuration
{
    public class Bill_ProductDetailConfig : IEntityTypeConfiguration<Bill_ProductDetail>
    {
        public void Configure(EntityTypeBuilder<Bill_ProductDetail> builder)
        {
            builder.ToTable("Bill_ProductDetail");
            builder.HasKey(x=> new {x.ProDetailId,x.BillId});
            builder.HasOne(x=>x.ProductDetail).WithMany(x=>x.Bill_ProductDetail).HasForeignKey(x=>x.ProDetailId);
            builder.HasOne(x => x.Bill).WithMany(x => x.Bill_ProductDetails).HasForeignKey(x => x.BillId);
        }
    }
}
