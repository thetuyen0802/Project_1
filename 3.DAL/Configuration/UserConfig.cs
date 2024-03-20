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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");/// Đặt tên cho bảng trong DB
            builder.HasKey(p => p.UserId);//Set khoá chính
            builder.Property(p => p.UserId).UseIdentityColumn(1,1); // tự tăng ID
            builder.HasOne(c=>c.Role).WithMany(x=>x.Users).HasForeignKey(x=>x.RoleId);
            builder.Property(x=>x.UserName).IsRequired();
            builder.Property(x=> x.Email).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
        }
    }
}
