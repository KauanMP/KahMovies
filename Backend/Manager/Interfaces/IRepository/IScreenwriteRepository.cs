using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IScreenwriteRepository
    {
        Task<IEnumerable<Screenwrite>> GetAllScreenWriterAsync();
        Task<Screenwrite> GetScreenWriterByIdAsync(int id);
        Task<Screenwrite> InsertScreenWriterAsync(Screenwrite screenwrite);
        Task<Screenwrite> UpdateScreenWriterAsync(Screenwrite screenwrite);
        Task<Screenwrite> DeleteScreenWriterAsync(int id);
    }
}