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
        public async Task<IEnumerable<AuthorView>> GetAllAuthorsAsync()
        {
            return await manager.GetAllAuthorsAsync();
        }

        [HttpGet("{id}")]
        public async Task<AuthorView> GetAuthorByIdAsync(int id)
        {
            return await manager.GetAuthorByIdAsync(id);
        }
    }
}