using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Category;

namespace Manager.Mappings
{
    public class NewCategoryMappingProfile : Profile
    {
        public NewCategoryMappingProfile()
        {
            CreateMap<Category, CategoryReference>().ReverseMap();
            CreateMap<Category, CategoryView>().ReverseMap();
            CreateMap<Category, NewCategory>().ReverseMap();
            CreateMap<CategoryUpdate, Category>().ReverseMap();
        }
    }
}