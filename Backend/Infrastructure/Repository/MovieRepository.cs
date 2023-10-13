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
            return await dbContext.Movies
            .Include(p => p.Authors)
            .Include(p => p.Categories)
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Movie> InsertMoviesAsync(Movie movie)
        {
            await InsertMovieAuthors(movie);
            await InsertMovieCategories(movie);

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

        public async Task InsertMovieCategories(Movie movie)
        {
            var findCategories = new List<Category>();
            foreach (var Categories in movie.Categories)
            {
                var findCategory = await dbContext.Categories.FindAsync(Categories.Id);
                findCategories.Add(findCategory);
            }
            movie.Categories = findCategories;
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