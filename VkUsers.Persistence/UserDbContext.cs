using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Interfaces;
using VkUsers.Domain;
using VkUsers.Persistence.EntityTypeConfigurations;

namespace VkUsers.Persistence
{
    public class UserDbContext : DbContext, IUserDbContext
    {
        public DbSet<user> users { get; set ; }
        public DbSet<user_group> user_groups { get ; set ; }
        public DbSet<user_state> user_states { get ; set ; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
