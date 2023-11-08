using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IProducerRepository
    {
        Task<IEnumerable<Producer>> GetAllProducersAsync();
        Task<Producer> GetProducerByIdAsync(int id);
        Task<Producer> InsertProducerAsync(Producer producer);
        Task<Producer> UpdateProducerAsync(Producer producer);
        Task DeleteProducerAsync(int id);
    }
}