using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Domain;

namespace VkUsers.Application.Interfaces
{
    public interface IUserDbContext
    {
        DbSet<user> users { get; set; }
        DbSet<user_group> user_groups { get; set; }
        DbSet<user_state> user_states { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        //int SaveChanges(CancellationToken cancellationToken);
    }
}
