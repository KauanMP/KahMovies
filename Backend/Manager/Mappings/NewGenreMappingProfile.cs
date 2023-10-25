using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Genre;

namespace Manager.Mappings
{
    public class NewGenreMappingProfile : Profile
    {
        public NewGenreMappingProfile()
        {
            CreateMap<Genre, GenreReference>().ReverseMap();
            CreateMap<Genre, GenreView>().ReverseMap();
            CreateMap<Genre, NewGenre>().ReverseMap();
            CreateMap<GenreUpdate, Genre>().ReverseMap();
        }
    }
}