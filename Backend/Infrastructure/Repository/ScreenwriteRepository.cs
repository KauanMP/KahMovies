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
    public class ScreenwriteRepository : IScreenwriteRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ScreenwriteRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Screenwrite>> GetAllScreenwriterAsync()
        {
            return await dbContext.Screenwriter.AsNoTracking().ToListAsync();
        }

        public async Task<Screenwrite> GetScreenwriterByIdAsync(int id)
        {
            return await dbContext.Screenwriter.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Screenwrite> InsertScreenwriterAsync(Screenwrite screenwrite)
        {
            await dbContext.Screenwriter.AddAsync(screenwrite);
            await dbContext.SaveChangesAsync();

            return screenwrite;
        }

        public async Task<Screenwrite> UpdateScreenwriterAsync(Screenwrite screenwrite)
        {
            var updatedScreenwriter = await dbContext.Screenwriter.FindAsync(screenwrite.Id);

            if (updatedScreenwriter == null)
            {
                return null;
            }

            dbContext.Entry(updatedScreenwriter).CurrentValues.SetValues(screenwrite);
            return updatedScreenwriter;
        }

        public async Task DeleteScreenwriterAsync(int id)
        {
            var deleteScreenwriter = await dbContext.Screenwriter.SingleOrDefaultAsync(p => p.Id == id);

            dbContext.Remove(deleteScreenwriter);
            await dbContext.SaveChangesAsync();
        }
    }
}