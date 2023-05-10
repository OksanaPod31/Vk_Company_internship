using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Interfaces;

namespace VkUsers.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        
        public DeleteUserCommandValidator()
        {
            

            RuleFor(cre => cre.Id).NotEqual(Guid.Empty);
        }
    }
}
