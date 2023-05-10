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
    public class GroupConfiguration : IEntityTypeConfiguration<user_group>
    {
        public void Configure(EntityTypeBuilder<user_group> builder)
        {
            builder.HasKey(e => e.id);
            builder.Property(e => e.code).IsRequired();
            builder.Property(e => e.description).IsRequired();
        }
    }
}
