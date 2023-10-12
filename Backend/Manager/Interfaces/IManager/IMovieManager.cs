using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews;

namespace Domain.Interfaces
{
    public interface IMovieViewManager
    {
        Task<IEnumerable<MovieView>> GetAllMovieViewsAsync();
        Task<MovieView> GetMovieViewByIdAsync(int id);
        Task<MovieView> InsertMovieViews(MovieView MovieView);
        Task<MovieView> UpdateMovieViewAsync(MovieView MovieView);
        Task DeleteMovieViewAsync(int id);
    }
}