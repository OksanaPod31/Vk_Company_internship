using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VkUsers.Application.Common.Mapping;
using VkUsers.Domain;

namespace VkUsers.Application.Users.Queries.GetUserList
{
    public class UserLookupDto : IMapWith<user>
    {
        

        public Guid id { get; set; }
        public string login { get; set; }
        public DateTime created_date { get; set; }      
        public StateDto state { get; set; }
        
        
        
        

        public void Mapping (Profile profile)
        {
            profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.id, 
                opt => opt.MapFrom(u => u.id));
            profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.login,
                opt => opt.MapFrom(u => u.login));
            profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.created_date,
                opt => opt.MapFrom(u => u.created_date));
            //profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.group, opt => opt.MapFrom(s => s.user_group));
            //profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.group, opt => opt.MapFrom(s => s.user_group));
            profile.CreateMap<user, UserLookupDto>().ForMember(dto => dto.state, opt => opt.MapFrom(s => s.user_state));
            
            
        }
       
    }
}
