using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Users.Commands.CreateUser;

namespace VkUsers.Application.Users.Queries.GetUserList
{
    public class GetListVm
    {
        public IList<UserLookupDto> Lookups { get; set; }
        public IList<GroupsDto> Groups { get; set; }
        public CreateUserDto CreateUser { get; set; }
    }
}
