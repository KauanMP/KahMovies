using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Director;

namespace Manager.Interfaces.IManager
{
    public interface IDirectorManager
    {
        Task<IEnumerable<DirectorView>> GetAllDirectorsAsync();
        Task<DirectorView> GetDirectorByIdAsync(int id);
        Task<DirectorView> InsertDirectorAsync(NewDirector newDirector);
        Task<DirectorView> UpdateDirectorAsync(DirectorUpdate DirectorUpdate);
        Task DeleteDirectorAsync(int id);
    }
}