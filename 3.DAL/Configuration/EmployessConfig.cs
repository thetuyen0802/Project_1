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
    public class EmployessConfig : IEntityTypeConfiguration<Employess>
    {
        public void Configure(EntityTypeBuilder<Employess> builder)
        {
            builder.ToTable("Employesses");
            builder.HasKey(x => x.EmployessId);
            builder.Property(X=>X.EmployessId).UseIdentityColumn(1,1);
           
        }
    }
}
