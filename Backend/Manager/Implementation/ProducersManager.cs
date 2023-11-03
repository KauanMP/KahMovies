using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities.MoviesInfo;
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

        public Task<ProducerView> GetProducerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProducerView> InsertProducerAsync(NewProducer newProducer)
        {
            throw new NotImplementedException();
        }

        public Task<ProducerView> UpdateProducerAsync(ProducerUpdate producerUpdate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProducerAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}