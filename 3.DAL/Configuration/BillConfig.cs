using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Configuration
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bills");
            builder.HasKey(x=>x.BillId);
            builder.Property(x=>x.BillId).UseIdentityColumn(1,1);
            
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.EmployessId).IsRequired();
            builder.Property(x=>x.CreateDate).HasDefaultValue(DateTime.Now);
            
            builder.HasOne(x => x.Employess).WithMany(a => a.Bills).HasForeignKey(a => a.EmployessId);
            builder.HasOne(x => x.Customer).WithMany(a => a.Bills).HasForeignKey(a => a.CustomerId);
        }
    }
}
