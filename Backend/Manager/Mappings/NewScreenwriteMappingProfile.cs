using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Screenwrite;

namespace Manager.Mappings
{
    public class NewScreenwriteMappingProfile : Profile
    {
        public NewScreenwriteMappingProfile()
        {
            CreateMap<Screenwrite, NewScreenwrite>().ReverseMap();
            CreateMap<Screenwrite, ScreenwriteReference>().ReverseMap();
            CreateMap<Screenwrite, ScreenwriteView>().ReverseMap();
            CreateMap<ScreenwriteUpdate, Screenwrite>().ReverseMap();
        }
    }
}