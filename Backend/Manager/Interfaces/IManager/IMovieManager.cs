using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews;

namespace Domain.Interfaces
{
    public interface IMovieManager
    {
        Task<IEnumerable<MovieView>> GetAllMovieAsync();
        Task<MovieView> GetMovieByIdAsync(int id);
        Task<MovieView> InsertMovieV(MovieView MovieView);
        Task<MovieView> UpdateMovieAsync(MovieView MovieView);
        Task DeleteMovieAsync(int id);
    }
}