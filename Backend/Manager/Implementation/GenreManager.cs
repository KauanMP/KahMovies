using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Genre;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class GenreManager : IGenreManager
    {
        private readonly IGenreRepository repository;
        private readonly IMapper mapper;

        public GenreManager(IGenreRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GenreView>> GetAllGenresAsync()
        {
            return mapper.Map<IEnumerable<Genre>, IEnumerable<GenreView>>(await repository.GetAllGenresAsync());
        }

        public async Task<GenreView> GetGenreByIdAsync(int id)
        {
            return mapper.Map<GenreView>(await repository.GetGenreByIdAsync(id));
        }

        public async Task<GenreView> InsertGenreAsync(NewGenre newGenre)
        {
            var findGenre = mapper.Map<Genre>(newGenre);
            return mapper.Map<GenreView>(await repository.InsertGenreAsync(findGenre));
        }

        public async Task<GenreView> UpdateGenreAsync(GenreUpdate GenreUpdate)
        {
            var findGenre = mapper.Map<Genre>(GenreUpdate);
            return mapper.Map<GenreView>(await repository.UpdateGenreAsync(findGenre));
        }

        public async Task DeleteGenreAsync(int id)
        {
            await repository.DeleteGenreAsync(id);
        }
    }
}