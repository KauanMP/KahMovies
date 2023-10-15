using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ModelViews.Author;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager manager;

        public AuthorController(IAuthorManager manager)
        {
            this.manager = manager;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            return Ok(await manager.GetAllAuthorsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            return Ok(await manager.GetAuthorByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertAuthors(NewAuthor newAuthor)
        {
            var insertAuthor = await manager.InsertAuthorAsync(newAuthor);
            return CreatedAtAction(nameof(GetAllAuthors), new {id = insertAuthor.Id}, insertAuthor);
        }
    }
}