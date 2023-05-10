using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Application.Users.Queries.GetUserDetails
{
    public class GetUserDetailsValidator : AbstractValidator<GetUserDetailsQuery>
    {
        public GetUserDetailsValidator()
        {
            RuleFor(cre => cre.Id).NotEqual(Guid.Empty);
        }
    }
}
