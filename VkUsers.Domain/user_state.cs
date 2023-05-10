using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Domain
{
    public class user_state
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }
}
