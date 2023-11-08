using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Screenwrite;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class ScreenwriteManager : IScreenwriteManager
    {
        private readonly IScreenwriteRepository repository;
        private readonly IMapper mapper;

        public ScreenwriteManager(IScreenwriteRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ScreenwriteView>> GetAllScreenwriterAsync()
        {
            return mapper.Map<IEnumerable<Screenwrite>, IEnumerable<ScreenwriteView>>(await repository.GetAllScreenwriterAsync());
        }

        public async Task<ScreenwriteView> GetScreenwriterByIdAsync(int id)
        {
            return mapper.Map<ScreenwriteView>(await repository.GetScreenwriterByIdAsync(id));
        }

        public async Task<ScreenwriteView> InsertScreenwriterAsync(NewScreenwrite newScreenwrite)
        {
            var insertScreenwrite = mapper.Map<Screenwrite>(newScreenwrite);
            return mapper.Map<ScreenwriteView>(await repository.InsertScreenwriterAsync(insertScreenwrite));
        }

        public async Task<ScreenwriteView> UpdateScreenwriterAsync(ScreenwriteUpdate screenwriteUpdate)
        {
            var updatedScreenwrite = mapper.Map<Screenwrite>(screenwriteUpdate);
            return mapper.Map<ScreenwriteView>(await repository.UpdateScreenwriterAsync(updatedScreenwrite));
        }

        public async Task DeleteScreenwriterAsync(int id)
        {
            await repository.DeleteScreenwriterAsync(id);
        }
    }
}