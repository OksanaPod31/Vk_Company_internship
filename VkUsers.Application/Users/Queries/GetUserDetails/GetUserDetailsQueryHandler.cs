using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Common.Exceptions;
using VkUsers.Application.Interfaces;
using VkUsers.Application.Users.Queries.GetUserList;
using VkUsers.Domain;

namespace VkUsers.Application.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDetailsDto>
    {
        private readonly IUserDbContext _userDbContext;
        private readonly IMapper _mapper;

        public GetUserDetailsQueryHandler(IUserDbContext userDbContext, IMapper mapper)
        {
            _userDbContext = userDbContext;
            _mapper = mapper;
        }

        public async Task<UserDetailsDto> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _userDbContext.users.FirstOrDefaultAsync(x => x.id == request.Id, cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(user), request.Id);
            }
            Guid id_g = entity.groupid;
            Guid id_s = entity.stateid;
            var groupentity = await _userDbContext.user_groups.FirstOrDefaultAsync(x => x.id == id_g, cancellationToken);
            var stateentity = await _userDbContext.user_states.FirstOrDefaultAsync(x => x.id == id_s, cancellationToken);
            var detailEntity = _mapper.Map<user, UserDetailsDto>(entity);
            detailEntity.state = _mapper.Map<user_state, StateDto>(stateentity);
            detailEntity.group = _mapper.Map<user_group, GroupsDto>(groupentity);
            return detailEntity;
        }
    }
}
