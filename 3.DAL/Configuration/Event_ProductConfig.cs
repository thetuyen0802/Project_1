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
    public class Event_ProductConfig : IEntityTypeConfiguration<Event_Product>
    {
        public void Configure(EntityTypeBuilder<Event_Product> builder)
        {
            builder.ToTable("Even_Products"); ;
            builder.HasKey(x => new { x.ProductId, x.EventId });
            builder.HasOne(x=>x.Product).WithMany(x=>x.Event_Products).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.Event).WithMany(x=>x.Event_Products).HasForeignKey(x=>x.EventId);
        }
    }
}
