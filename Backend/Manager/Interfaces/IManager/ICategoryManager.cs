using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Category;

namespace Manager.Interfaces.IManager
{
    public interface ICategoryManager
    {
        Task<IEnumerable<NewCategory>> GetAllCategoriesAsync();
        Task<NewCategory> GetCategoryByIdAsync(int id);
        Task<NewCategory> InsertCategoryAsync(NewCategory newCategory);
        Task<NewCategory> UpdateCategoryAsync(CategoryUpdate categoryUpdate);
        Task DeleteCategoryAsync(int id);
    }
}