using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Application.Users.Queries.GetUserList
{
    public class GetUserListQuery : IRequest<GetListVm>
    {
    }
}
