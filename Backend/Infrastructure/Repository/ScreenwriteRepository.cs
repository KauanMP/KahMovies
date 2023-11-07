using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Manager.Interfaces.IRepository;

namespace Infrastructure.Repository
{
    public class ScreenwriteRepository : IScreenwriteRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ScreenwriteRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<IEnumerable<Screenwrite>> GetAllScreenWriterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Screenwrite> GetScreenWriterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Screenwrite> InsertScreenWriterAsync(Screenwrite screenwrite)
        {
            throw new NotImplementedException();
        }

        public Task<Screenwrite> UpdateScreenWriterAsync(Screenwrite screenwrite)
        {
            throw new NotImplementedException();
        }

        public Task<Screenwrite> DeleteScreenWriterAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}