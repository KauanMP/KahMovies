using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IDirectorRepository
    {
        Task<IEnumerable<Director>> GetAllDirectorsAsync();
        Task<Director> GetDirectorByIdAsync(int id);
        Task<Director> InsertDirectorAsync(Director Director);
        Task<Director> UpdateDirectorAsync(Director Director);
        Task DeleteDirectorAsync(int id);
    }
}