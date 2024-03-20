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
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors");
            builder.HasKey(x => x.ColorId);
            builder.Property(x=>x.ColorId).UseIdentityColumn(1,1);
            builder.Property(x=>x.ColorCode).IsRequired();
            builder.Property(x=>x.ColorName).IsRequired();

        }
    }
}
