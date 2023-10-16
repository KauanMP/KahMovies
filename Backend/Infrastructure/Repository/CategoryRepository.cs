using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Manager.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await dbContext.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await dbContext.Categories.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Category> InsertCategoryAsync(Category category)
        {
            await dbContext.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            var updateCategory = await dbContext.Categories.FindAsync(category.Id);

            if (updateCategory == null)
            {
                return null;
            }

            dbContext.Entry(updateCategory).CurrentValues.SetValues(category);
            await dbContext.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var deleteCategory = await dbContext.Categories.FirstOrDefaultAsync(p => p.Id == id);

            dbContext.Remove(deleteCategory);
            await dbContext.SaveChangesAsync();
        }
    }
}