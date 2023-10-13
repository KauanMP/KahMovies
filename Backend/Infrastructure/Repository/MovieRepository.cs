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
            .Include(p => p.Categories)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await dbContext.Movies.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<Movie> InsertMovies(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}