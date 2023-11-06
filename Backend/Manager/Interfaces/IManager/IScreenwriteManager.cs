using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Screenwrite;

namespace Manager.Interfaces.IManager
{
    public interface IScreenwriteManager
    {
        Task<IEnumerable<ScreenwriteView>> GetAllScreenWriterAsync();
        Task<ScreenwriteView> GetScreenWriterByIdAsync(int id);
        Task<ScreenwriteView> InsertScreenWriterAsync(NewScreenwrite newScreenwrite);
        Task<ScreenwriteView> UpdateScreenWriterAsync(ScreenwriteUpdate screenwriteUpdate);
        Task DeleteScreenWriterAsync(int id);
    }
}