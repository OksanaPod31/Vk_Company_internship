using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VkUsers.Application.Interfaces;

namespace VkUsers.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator: AbstractValidator<CreateUserCommand>
    {
        //private readonly IUserDbContext _userDbContext;
        public CreateUserCommandValidator(IUserDbContext _userDbContext)
        {


            
            var groupentity = _userDbContext.user_groups.FirstOrDefault(x => x.code == "Admin");
            var userentity = _userDbContext.users.FirstOrDefault(x => x.groupid == groupentity.id);

            if (userentity != null)
            {
                RuleFor(cre => cre.groupId).NotEqual(groupentity.id);
            }


            RuleFor(cre => cre.Id).NotEqual(Guid.Empty);
            RuleFor(cre => cre.login).NotEmpty();
            RuleFor(cre => cre.password).NotEmpty();
            RuleFor(cre => cre.groupId).NotEmpty();

        }
    }
}
