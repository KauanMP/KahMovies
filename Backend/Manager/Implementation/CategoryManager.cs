using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Category;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository repository;
        private readonly IMapper mapper;

        public CategoryManager(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CategoryView>> GetAllCategoriesAsync()
        {
            return mapper.Map<IEnumerable<Category>, IEnumerable<CategoryView>>(await repository.GetAllCategoriesAsync());
        }

        public async Task<CategoryView> GetCategoryByIdAsync(int id)
        {
            return mapper.Map<CategoryView>(await repository.GetCategoryByIdAsync(id));
        }

        public async Task<CategoryView> InsertCategoryAsync(NewCategory newCategory)
        {
            var findCategory = mapper.Map<Category>(newCategory);
            return mapper.Map<CategoryView>(await repository.InsertCategoryAsync(findCategory));
        }

        public async Task<CategoryView> UpdateCategoryAsync(CategoryUpdate categoryUpdate)
        {
            var findCategory = mapper.Map<Category>(categoryUpdate);
            return mapper.Map<CategoryView>(await repository.UpdateCategoryAsync(findCategory));
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await repository.DeleteCategoryAsync(id);
        }
    }
}