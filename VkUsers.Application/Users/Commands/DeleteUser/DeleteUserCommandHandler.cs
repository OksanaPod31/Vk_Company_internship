using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Common.Exceptions;
using VkUsers.Application.Interfaces;
using VkUsers.Domain;

namespace VkUsers.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserDbContext _userDbContext;
        public DeleteUserCommandHandler(IUserDbContext userDbContext) { _userDbContext = userDbContext; }
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var block = await _userDbContext.user_states.FirstOrDefaultAsync(d => d.code == "Blocked", cancellationToken);
            var entity = await _userDbContext.users.FindAsync(new object[] { request.Id }, cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(user), request.Id);
            }

            //_userDbContext.users.Remove(entity);
            entity.stateid = block.id;
            await _userDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
