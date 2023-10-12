using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync(Movie movie);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> UpdateMovieAsync(Movie movie);
        Task DeleteMovieAsync(int id);
    }
}