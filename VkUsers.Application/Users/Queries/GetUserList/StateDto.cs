using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Common.Mapping;
using VkUsers.Domain;

namespace VkUsers.Application.Users.Queries.GetUserList
{
    public class StateDto : IMapWith<user_state>
    {
        public string code { get; set; }
        public string description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<user_state, StateDto>().ForMember(dto => dto.code, opt => opt.MapFrom(us => us.code));
            profile.CreateMap<user_state, StateDto>().ForMember(dto => dto.description, opt => opt.MapFrom(us => us.description));
        }
    }
}
