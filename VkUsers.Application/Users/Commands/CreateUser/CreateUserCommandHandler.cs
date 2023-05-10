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

namespace VkUsers.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserDbContext _userDbContext;
        public CreateUserCommandHandler(IUserDbContext userDbContext) { _userDbContext = userDbContext; }

       
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var active = _userDbContext.user_states.FirstOrDefault(d => d.code == "Active");
            var userEntity = new user
            {
                id = request.Id,
                login = request.login,
                password = request.password,
                created_date = request.created_date,
                groupid = request.groupId,
                stateid = active.id //Guid.Parse("16f1454c-0ed7-406b-bb58-b21009faac94")

            };

            await _userDbContext.users.AddAsync(userEntity);
            await _userDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }

}
