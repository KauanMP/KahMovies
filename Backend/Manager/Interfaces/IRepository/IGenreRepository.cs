using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        Task<Genre> GetGenreByIdAsync(int id);
        Task<Genre> InsertGenreAsync(Genre Genre);
        Task<Genre> UpdateGenreAsync(Genre Genre);
        Task DeleteGenreAsync(int id);
    }
}