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

        public Task<Category> InsertCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}