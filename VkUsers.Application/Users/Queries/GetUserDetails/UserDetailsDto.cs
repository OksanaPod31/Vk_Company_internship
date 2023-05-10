using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Common.Mapping;
using VkUsers.Application.Users.Queries.GetUserList;
using VkUsers.Domain;

namespace VkUsers.Application.Users.Queries.GetUserDetails
{
    public class UserDetailsDto : IMapWith<user>
    {
        public Guid id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime created_date { get; set; }

        public GroupsDto group { get; set; }
        public StateDto state { get; set; } 

        public void Mapping(Profile profile)
        {
            profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.id,
                opt => opt.MapFrom(u => u.id));
            profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.login,
                opt => opt.MapFrom(u => u.login));
            profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.password,
                opt => opt.MapFrom(u => u.password));
            profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.created_date,
                opt => opt.MapFrom(u => u.created_date));
            //profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.group,
            //    opt => opt.MapFrom(u => u.user_group));
            //profile.CreateMap<user, UserDetailsDto>().ForMember(dto => dto.state, opt => opt.MapFrom(s => s.user_state));

        }
    }
}
