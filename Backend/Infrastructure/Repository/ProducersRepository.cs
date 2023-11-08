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
    public class ProducersRepository : IProducerRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProducersRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Producer>> GetAllProducersAsync()
        {
            return await dbContext.Producers.AsNoTracking().ToListAsync();
        }

        public async Task<Producer> GetProducerByIdAsync(int id)
        {
            return await dbContext.Producers.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Producer> InsertProducerAsync(Producer producer)
        {
            await dbContext.Producers.AddAsync(producer);
            await dbContext.SaveChangesAsync();

            return producer;
        }

        public async Task<Producer> UpdateProducerAsync(Producer producer)
        {
            var findProducer = await dbContext.Producers.FindAsync(producer.Id);

            if (findProducer == null)
            {
                return null;
            }

            dbContext.Entry(findProducer).CurrentValues.SetValues(producer);
            await dbContext.SaveChangesAsync();

            return findProducer;
        }

        public async Task DeleteProducerAsync(int id)
        {
            var findProducer = await dbContext.Producers.SingleOrDefaultAsync(p => p.Id == id);

            dbContext.Remove(findProducer);
            await dbContext.SaveChangesAsync();
        }
    }
}