using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ModelViews;
using Domain.ModelViews.Movie;

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

        public async Task<IEnumerable<MovieView>> GetAllMoviesAsync()
        {
            return mapper.Map<IEnumerable<Movie>, IEnumerable<MovieView>>(await repository.GetAllMoviesAsync());
        }

        public async Task<MovieView> GetMovieByIdAsync(int id)
        {
            return mapper.Map<MovieView>(await repository.GetMovieByIdAsync(id));
        }

        public async Task<MovieView> InsertMovieAsync(NewMovie newMovie)
        {
            var movie = mapper.Map<Movie>(newMovie);
            return mapper.Map<MovieView>(await repository.InsertMoviesAsync(movie));
        }

        public async Task<MovieView> UpdateMovieAsync(MovieUpdate movieUpdate)
        {
            var movie = mapper.Map<Movie>(movieUpdate);
            return mapper.Map<MovieView>(await repository.UpdateMovieAsync(movie));
        }

        public Task DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}