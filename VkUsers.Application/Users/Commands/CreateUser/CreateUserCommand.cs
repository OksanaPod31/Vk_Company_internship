using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest
    {
        public Guid Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime created_date { get; set; }
        public Guid groupId { get; set; }
        public Guid stateId { get; set; }

    }
}
