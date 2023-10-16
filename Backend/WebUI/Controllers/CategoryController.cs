using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ModelViews.Category;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager manager;

        public CategoryController(ICategoryManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await manager.GetAllCategoriesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            return Ok(await manager.GetCategoryByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertCategory(NewCategory newCategory)
        {
            var insertCategory = await manager.InsertCategoryAsync(newCategory);
            return CreatedAtAction(nameof(GetAllCategories), new {id = insertCategory.Id}, insertCategory);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryUpdate categoryUpdate)
        {
            var updateCategory = await manager.UpdateCategoryAsync(categoryUpdate);

            if (updateCategory == null)
            {
                return NotFound();
            }

            return Ok(categoryUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await manager.DeleteCategoryAsync(id);
            return NoContent();
        }
    }
}