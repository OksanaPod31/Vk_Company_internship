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

namespace VkUsers.Application.Users.Queries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, GetListVm>
    {
        private readonly IUserDbContext _userDbContext;
        private readonly IMapper mapper;

        public GetUserListQueryHandler(IUserDbContext userDbContext, IMapper mapper) { _userDbContext = userDbContext; this.mapper = mapper; }
        public async Task<GetListVm> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            
            var empQuery = await _userDbContext.users.ProjectTo<UserLookupDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new GetListVm { Lookups = empQuery };
        }
    }
}
