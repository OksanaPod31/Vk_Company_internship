using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Users.Queries.GetUserList;

namespace VkUsers.Application.Groups.Queries.GetGroupList
{
    public class GetGroupQuery : IRequest<GetListVm>
    {
    }
}
