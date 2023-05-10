using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Interfaces;
using VkUsers.Application.Users.Queries.GetUserList;

namespace VkUsers.Application.Groups.Queries.GetGroupList
{
    public class GetGroupQuerHandler : IRequestHandler<GetGroupQuery, GetListVm>
    {
        private readonly IMapper mapper;
        private readonly IUserDbContext userDbContext;
        public GetGroupQuerHandler(IMapper mapper, IUserDbContext userDbContext)
        {
            this.mapper = mapper;
            this.userDbContext = userDbContext;
        } 
        public async Task<GetListVm> Handle(GetGroupQuery request, CancellationToken cancellationToken)
        {
            IList<GroupsDto> ent = await userDbContext.user_groups.ProjectTo<GroupsDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            
            return new GetListVm { Groups = ent };
        }
    }
}
