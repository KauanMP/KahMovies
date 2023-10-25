using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
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
            .Include(p => p.Authors)
            .Include(p => p.Genres)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await dbContext.Movies
            .Include(p => p.Authors)
            .Include(p => p.Genres)
            .AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Movie> InsertMoviesAsync(Movie movie)
        {
            await InsertMovieAuthors(movie);
            await InsertMovieGenres(movie);

            await dbContext.Movies.AddAsync(movie);
            await dbContext.SaveChangesAsync();
            return movie;
        }

        private async Task InsertMovieAuthors(Movie movie)
        {
            var findAuthors = new List<Author>();
            foreach (var Author in movie.Authors)
            {
                var findAuthor = await dbContext.Authors.FindAsync(Author.Id);
                findAuthors.Add(findAuthor);
            }
            movie.Authors = findAuthors;
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

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            var findMovies = await dbContext.Movies.Include(p => p.Authors).Include(p => p.Genres).SingleOrDefaultAsync(p => p.Id == movie.Id);

            if (findMovies == null)
            {
                return null;
            }

            dbContext.Entry(findMovies).CurrentValues.SetValues(movie);
            await UpdateMovieAuthors(movie, findMovies);
            await UpdateMovieGenres(movie, findMovies);

            await dbContext.SaveChangesAsync();
            return findMovies;
        }

        private async Task UpdateMovieAuthors(Movie movie, Movie findMovies)
        {
            findMovies.Authors.Clear();
            foreach (var Author in movie.Authors)
            {
                var findAuthor = await dbContext.Authors.FindAsync(Author.Id);
                findMovies.Authors.Add(findAuthor);
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