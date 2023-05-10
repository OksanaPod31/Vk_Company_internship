using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Common.Mapping;

namespace VkUsers.Application.Users.Commands.CreateUser
{
    public class CreateUserDto : IMapWith<CreateUserCommand>
    {
        public Guid Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime created_date { get; set; }
        public Guid groupId { get; set; }
        

        public void Mapping(Profile profile)
        {

            profile.CreateMap<CreateUserDto, CreateUserCommand>().ForMember(cre => cre.Id, opt => opt.MapFrom(com => com.Id))
            .ForMember(cre => cre.login, opt => opt.MapFrom(com => com.login))
            .ForMember(cre => cre.password, opt => opt.MapFrom(com => com.password))
            .ForMember(cre => cre.created_date, opt => opt.MapFrom(com => com.created_date))
            .ForMember(cre => cre.groupId, opt => opt.MapFrom(com => com.groupId));
                


        }

    }
}
