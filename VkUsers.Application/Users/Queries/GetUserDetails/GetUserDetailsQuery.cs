using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Users.Queries.GetUserList;

namespace VkUsers.Application.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IRequest<UserDetailsDto>
    {
        public Guid Id { get; set; }    
    }
}
