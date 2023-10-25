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
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ApplicationDbContext dbContext;

        public DirectorRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Director>> GetAllDirectorsAsync()
        {
            return await dbContext.Directors.AsNoTracking().ToListAsync();
        }

        public async Task<Director> GetDirectorByIdAsync(int id)
        {
            return await dbContext.Directors.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Director> InsertDirectorAsync(Director Director)
        {
            await dbContext.AddAsync(Director);
            await dbContext.SaveChangesAsync();

            return Director;
        }

        public async Task<Director> UpdateDirectorAsync(Director Director)
        {
            var findDirectors = await dbContext.Directors.FindAsync(Director.Id);

            if (findDirectors == null)
            {
                return null;
            }

            dbContext.Entry(findDirectors).CurrentValues.SetValues(Director);
            await dbContext.SaveChangesAsync();

            return Director;
        }

        public async Task DeleteDirectorAsync(int id)
        {
            var findDirectors = await dbContext.Directors.FindAsync(id);

            dbContext.Directors.Remove(findDirectors);
            await dbContext.SaveChangesAsync();
        }
    }
}