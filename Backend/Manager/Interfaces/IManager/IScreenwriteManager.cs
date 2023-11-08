using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Screenwrite;

namespace Manager.Interfaces.IManager
{
    public interface IScreenwriteManager
    {
        Task<IEnumerable<ScreenwriteView>> GetAllScreenwriterAsync();
        Task<ScreenwriteView> GetScreenwriterByIdAsync(int id);
        Task<ScreenwriteView> InsertScreenwriterAsync(NewScreenwrite newScreenwrite);
        Task<ScreenwriteView> UpdateScreenwriterAsync(ScreenwriteUpdate screenwriteUpdate);
        Task DeleteScreenwriterAsync(int id);
    }
}