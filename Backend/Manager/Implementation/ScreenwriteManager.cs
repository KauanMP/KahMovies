using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Screenwrite;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class ScreenwriteManager : IScreenwriteManager
    {
        private readonly IScreenwriteRepository repository;

        public ScreenwriteManager(IScreenwriteRepository repository)
        {
            this.repository = repository;
        }
        
        public Task<IEnumerable<ScreenwriteView>> GetAllScreenWriterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ScreenwriteView> GetScreenWriterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ScreenwriteView> InsertScreenWriterAsync(NewScreenwrite newScreenwrite)
        {
            throw new NotImplementedException();
        }

        public Task<ScreenwriteView> UpdateScreenWriterAsync(ScreenwriteUpdate screenwriteUpdate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteScreenWriterAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}