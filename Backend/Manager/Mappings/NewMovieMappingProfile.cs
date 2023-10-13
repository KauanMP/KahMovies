using AutoMapper;
using Domain.Entities;
using Domain.ModelViews;
using Domain.ModelViews.Author;
using Domain.ModelViews.Category;
using Domain.ModelViews.Movie;

namespace Manager.Mappings
{
    public class NewMovieMappingProfile : Profile
    {
        public NewMovieMappingProfile()
        {
            CreateMap<NewMovie, Movie>();
            CreateMap<Movie, MovieView>();
            CreateMap<Author, AuthorReference>().ReverseMap();
            CreateMap<Author, AuthorView>().ReverseMap();
            CreateMap<Author, NewAuthor>().ReverseMap();
            CreateMap<Category, CategoryReference>().ReverseMap();
            CreateMap<Category, CategoryView>().ReverseMap();
            CreateMap<Category, NewCategory>().ReverseMap();
            CreateMap<MovieUpdate, Movie>().ReverseMap();
        }
    }
}