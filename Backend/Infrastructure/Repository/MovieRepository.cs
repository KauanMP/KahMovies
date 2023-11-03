using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.MoviesInfo;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{

    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext dbContext;
        public MovieRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await dbContext.Movies
            .Include(p => p.Directors)
            .Include(p => p.Genres)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await dbContext.Movies
            .Include(p => p.Directors)
            .Include(p => p.Genres)
            .AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Movie> InsertMoviesAsync(Movie movie)
        {
            await InsertMovieDirectors(movie);
            await InsertMovieGenres(movie);
            await InsertMovieProducers(movie);

            await dbContext.Movies.AddAsync(movie);
            await dbContext.SaveChangesAsync();
            return movie;
        }

        private async Task InsertMovieDirectors(Movie movie)
        {
            var findDirectors = new List<Director>();
            foreach (var Director in movie.Directors)
            {
                var findDirector = await dbContext.Directors.FindAsync(Director.Id);
                findDirectors.Add(findDirector);
            }
            movie.Directors = findDirectors;
        }

        public async Task InsertMovieGenres(Movie movie)
        {
            var findGenres = new List<Genre>();
            foreach (var Genres in movie.Genres)
            {
                var findGenre = await dbContext.Genres.FindAsync(Genres.Id);
                findGenres.Add(findGenre);
            }
            movie.Genres = findGenres;
        }

        private async Task InsertMovieProducers(Movie movie)
        {
            var findProducers = new List<Producer>();
            foreach (var Producer in movie.Producers)
            {
            var findProducer = await dbContext.Producers.FindAsync(Producer.Id);
            findProducers.Add(findProducer);
            }
            movie.Producers = findProducers;
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            var findMovies = await dbContext.Movies.Include(p => p.Directors).Include(p => p.Genres).SingleOrDefaultAsync(p => p.Id == movie.Id);

            if (findMovies == null)
            {
                return null;
            }

            dbContext.Entry(findMovies).CurrentValues.SetValues(movie);
            await UpdateMovieDirectors(movie, findMovies);
            await UpdateMovieGenres(movie, findMovies);

            await dbContext.SaveChangesAsync();
            return findMovies;
        }

        private async Task UpdateMovieDirectors(Movie movie, Movie findMovies)
        {
            findMovies.Directors.Clear();
            foreach (var Director in movie.Directors)
            {
                var findDirector = await dbContext.Directors.FindAsync(Director.Id);
                findMovies.Directors.Add(findDirector);
            }
        }

        private async Task UpdateMovieGenres(Movie movie, Movie findMovies)
        {
            findMovies.Genres.Clear();
            foreach (var Genre in movie.Genres)
            {
                var findGenres = await dbContext.Genres.FindAsync(Genre.Id);
                findMovies.Genres.Add(findGenres);
            }
        }

        public async Task<Movie> DeleteMovieAsync(int id)
        {
            var findMovies = await dbContext.Movies.FindAsync(id);

            if (findMovies == null)
            {
                return null;
            }

            var removeMovie = dbContext.Movies.Remove(findMovies);
            await dbContext.SaveChangesAsync();
            
            return removeMovie.Entity;
        }

    }
}