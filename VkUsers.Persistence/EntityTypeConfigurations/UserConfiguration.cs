using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Domain;

namespace VkUsers.Persistence.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder)
        {
            builder.HasKey(e => e.id);
            builder.Property(e => e.login).IsRequired();
            builder.Property(e => e.password).IsRequired();
            builder.Property(e => e.groupid).IsRequired();
            builder.Property(e => e.stateid).IsRequired();
            builder.Property(e => e.created_date).HasConversion(
                src => src.Kind == DateTimeKind.Utc ? src : DateTime.SpecifyKind(src, DateTimeKind.Utc),
                dst => dst.Kind == DateTimeKind.Utc ? dst : DateTime.SpecifyKind(dst, DateTimeKind.Utc));

     

        }
    }
}
