using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ModelViews;
using Domain.ModelViews.Movie;

namespace Domain.Interfaces
{
    public interface IMovieManager
    {
        Task<IEnumerable<MovieView>> GetAllMoviesAsync();
        Task<MovieView> GetMovieByIdAsync(int id);
        Task<MovieView> InsertMovieAsync(NewMovie newMovie);
        Task<MovieView> UpdateMovieAsync(MovieUpdate movieUpdate);
        Task DeleteMovieAsync(int id);
    }
}