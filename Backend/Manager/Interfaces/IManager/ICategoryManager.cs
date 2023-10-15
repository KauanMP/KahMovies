using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Category;

namespace Manager.Interfaces.IManager
{
    public interface ICategoryManager
    {
        Task<IEnumerable<CategoryView>> GetAllCategoriesAsync();
        Task<CategoryView> GetCategoryByIdAsync(int id);
        Task<CategoryView> InsertCategoryAsync(NewCategory newCategory);
        Task<CategoryView> UpdateCategoryAsync(CategoryUpdate categoryUpdate);
        Task DeleteCategoryAsync(int id);
    }
}