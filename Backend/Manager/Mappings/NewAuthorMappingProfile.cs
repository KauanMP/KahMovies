using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Author;

namespace Manager.Mappings
{
    public class NewAuthorMappingProfile : Profile
    {
        public NewAuthorMappingProfile()
        {
            CreateMap<Author, AuthorReference>().ReverseMap();
            CreateMap<Author, AuthorView>().ReverseMap();
            CreateMap<Author, NewAuthor>().ReverseMap();
            CreateMap<AuthorUpdate, Author>().ReverseMap();
        }
    }
}