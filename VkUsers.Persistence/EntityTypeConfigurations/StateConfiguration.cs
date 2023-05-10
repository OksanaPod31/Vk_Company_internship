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
    public class StateConfiguration : IEntityTypeConfiguration<user_state>
    {
        public void Configure(EntityTypeBuilder<user_state> builder)
        {
            builder.HasKey(e => e.id);
            builder.Property(e => e.code).IsRequired();
            builder.Property(e => e.description).IsRequired();
        }
    }
}
