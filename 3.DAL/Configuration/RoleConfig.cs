using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Configuration
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(c => c.RoleId);
            builder.Property(c=>c.RoleId).UseIdentityColumn(1,1);
            //builder.HasOne(p=>p.Users).WithMany()

        }
    }
}
