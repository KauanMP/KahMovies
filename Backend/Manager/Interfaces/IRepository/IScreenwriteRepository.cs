using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IScreenwriteRepository
    {
        Task<IEnumerable<Screenwrite>> GetAllScreenwriterAsync();
        Task<Screenwrite> GetScreenwriterByIdAsync(int id);
        Task<Screenwrite> InsertScreenwriterAsync(Screenwrite screenwrite);
        Task<Screenwrite> UpdateScreenwriterAsync(Screenwrite screenwrite);
        Task DeleteScreenwriterAsync(int id);
    }
}