using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Director;

namespace Manager.Mappings
{
    public class NewDirectorMappingProfile : Profile
    {
        public NewDirectorMappingProfile()
        {
            CreateMap<Director, DirectorReference>().ReverseMap();
            CreateMap<Director, DirectorView>().ReverseMap();
            CreateMap<Director, NewDirector>().ReverseMap();
            CreateMap<DirectorUpdate, Director>().ReverseMap();
        }
    }
}