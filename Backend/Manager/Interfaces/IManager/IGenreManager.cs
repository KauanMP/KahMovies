using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Genre;

namespace Manager.Interfaces.IManager
{
    public interface IGenreManager
    {
        Task<IEnumerable<GenreView>> GetAllGenresAsync();
        Task<GenreView> GetGenreByIdAsync(int id);
        Task<GenreView> InsertGenreAsync(NewGenre newGenre);
        Task<GenreView> UpdateGenreAsync(GenreUpdate GenreUpdate);
        Task DeleteGenreAsync(int id);
    }
}