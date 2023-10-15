using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Manager.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository repository;

        public AuthorController(IAuthorRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await repository.GetAllAuthorsAsync();
        }

    }
}