using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ModelViews.Director;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorManager manager;

        public DirectorController(IDirectorManager manager)
        {
            this.manager = manager;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await manager.GetAllDirectorsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await manager.GetDirectorByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewDirector newDirector)
        {
            var insertDirector = await manager.InsertDirectorAsync(newDirector);
            return CreatedAtAction(nameof(GetAll), new {id = insertDirector.Id}, insertDirector);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DirectorUpdate DirectorUpdate)
        {
            var updateDirector = await manager.UpdateDirectorAsync(DirectorUpdate);

            if(DirectorUpdate == null)
            {
                return NotFound();
            }

            return Ok(updateDirector);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteDirectorAsync(id);
            return NoContent();
        }
    }
}