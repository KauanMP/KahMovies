using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Director;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class DirectorManager : IDirectorManager
    {
        private readonly IDirectorRepository repository;
        private readonly IMapper mapper;

        public DirectorManager(IDirectorRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DirectorView>> GetAllDirectorsAsync()
        {
            return mapper.Map<IEnumerable<Director>, IEnumerable<DirectorView>>(await repository.GetAllDirectorsAsync());
        }

        public async Task<DirectorView> GetDirectorByIdAsync(int id)
        {
            return mapper.Map<DirectorView>(await repository.GetDirectorByIdAsync(id));
        }

        public async Task<DirectorView> InsertDirectorAsync(NewDirector newDirector)
        {
            var findDirector = mapper.Map<Director>(newDirector);
            return mapper.Map<DirectorView>(await repository.InsertDirectorAsync(findDirector));
        }

        public async Task<DirectorView> UpdateDirectorAsync(DirectorUpdate DirectorUpdate)
        {
            var findDirector = mapper.Map<Director>(DirectorUpdate);
            return mapper.Map<DirectorView>(await repository.UpdateDirectorAsync(findDirector));
        }

        public async Task DeleteDirectorAsync(int id)
        {
            await repository.DeleteDirectorAsync(id);
        }
    }
}