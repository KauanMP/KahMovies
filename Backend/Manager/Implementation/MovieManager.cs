using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ModelViews;

namespace Manager.Implementation
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieRepository repository;
        private readonly IMapper mapper;

        public MovieManager(IMovieRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<MovieView>> GetAllMovieAsync()
        {
            return mapper.Map<IEnumerable<Movie>, IEnumerable<MovieView>>(await repository.GetAllMoviesAsync());
        }

        public Task<MovieView> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MovieView> InsertMovieV(MovieView MovieView)
        {
            throw new NotImplementedException();
        }

        public Task<MovieView> UpdateMovieAsync(MovieView MovieView)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}