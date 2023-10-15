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
            CreateMap<MovieUpdate, Movie>().ReverseMap();
        }
    }
}