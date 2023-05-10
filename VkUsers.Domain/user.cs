using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Domain
{
    public class user
    {
        public Guid id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime created_date { get; set; }


        [ForeignKey(nameof(user_group))]
        public Guid groupid { get; set; }
        public user_group user_group { get; set; }


        [ForeignKey(nameof(user_state))]
        public Guid stateid { get; set; }
        public user_state user_state { get; set; }


    }
}
