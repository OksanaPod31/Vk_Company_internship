using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Application.Common.Exceptions
{
    public class ExistingUserException : Exception
    {
        public ExistingUserException(string name) : base($"Entity {name} already exist") { }
    }
}
