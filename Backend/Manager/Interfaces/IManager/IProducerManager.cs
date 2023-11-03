using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Producers;

namespace Manager.Interfaces.IManager
{
    public interface IProducerManager
    {
        Task<IEnumerable<ProducerView>> GetAllProducersAsync();
        Task<ProducerView> GetProducerByIdAsync(int id);
        Task<ProducerView> InsertProducerAsync(NewProducer newProducer);
        Task<ProducerView> UpdateProducerAsync(ProducerUpdate producerUpdate);
        Task DeleteProducerAsync(int id);
    }
}