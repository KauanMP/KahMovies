using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.User;

namespace Manager.Mappings
{
    public class NewLoginMappingProfile : Profile
    {
        public NewLoginMappingProfile()
        {
            CreateMap<User, NewUser>().ReverseMap();
            CreateMap<User, UserView>().ReverseMap();
        }
    }
}