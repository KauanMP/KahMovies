using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using Domain.ModelViews;

namespace Manager.Implementation
{
    public class MovieManager : IMovieViewManager
    {
        private readonly IMovieRepository repository;
        private readonly IMapper mapper;
        
        public MovieManager(IMovieRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<MovieView>> GetAllMovieViewsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovieView> GetMovieViewByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovieView> InsertMovieViews(MovieView MovieView)
        {
            throw new NotImplementedException();
        }

        public Task<MovieView> UpdateMovieViewAsync(MovieView MovieView)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovieViewAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}