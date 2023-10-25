using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Manager.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext dbContext;

        public GenreRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Genre>> GetAllGenresAsync()
        {
            return await dbContext.Genres.AsNoTracking().ToListAsync();
        }

        public async Task<Genre> GetGenreByIdAsync(int id)
        {
            return await dbContext.Genres.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Genre> InsertGenreAsync(Genre Genre)
        {
            await dbContext.AddAsync(Genre);
            await dbContext.SaveChangesAsync();

            return Genre;
        }

        public async Task<Genre> UpdateGenreAsync(Genre Genre)
        {
            var updateGenre = await dbContext.Genres.FindAsync(Genre.Id);

            if (updateGenre == null)
            {
                return null;
            }

            dbContext.Entry(updateGenre).CurrentValues.SetValues(Genre);
            await dbContext.SaveChangesAsync();
            return Genre;
        }

        public async Task DeleteGenreAsync(int id)
        {
            var deleteGenre = await dbContext.Genres.FirstOrDefaultAsync(p => p.Id == id);

            dbContext.Remove(deleteGenre);
            await dbContext.SaveChangesAsync();
        }
    }
}