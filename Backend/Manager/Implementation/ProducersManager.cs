using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Producers;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class ProducersManager : IProducerManager
    {
        private readonly IProducerRepository repository;
        private readonly IMapper mapper;

        public ProducersManager(IProducerRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProducerView>> GetAllProducersAsync()
        {
            return mapper.Map<IEnumerable<Producer>, IEnumerable<ProducerView>>(await repository.GetAllProducersAsync());
        }

        public async Task<ProducerView> GetProducerByIdAsync(int id)
        {
            return mapper.Map<ProducerView>(await repository.GetProducerByIdAsync(id));
        }

        public async Task<ProducerView> InsertProducerAsync(NewProducer newProducer)
        {
            var insertProducer = mapper.Map<Producer>(newProducer);
            return mapper.Map<ProducerView>(await repository.InsertProducerAsync(insertProducer));
        }

        public async Task<ProducerView> UpdateProducerAsync(ProducerUpdate producerUpdate)
        {
            var updateProducer = mapper.Map<Producer>(producerUpdate);
            return mapper.Map<ProducerView>(await repository.UpdateProducerAsync(updateProducer));
        }

        public async Task DeleteProducerAsync(int id)
        {
            await repository.DeleteProducerAsync(id);
        }
    }
}