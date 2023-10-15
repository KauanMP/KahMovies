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
    }
}