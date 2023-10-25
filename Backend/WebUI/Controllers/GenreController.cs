using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ModelViews.Genre;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreManager manager;

        public GenreController(IGenreManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await manager.GetAllGenresAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await manager.GetGenreByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewGenre newGenre)
        {
            var insertGenre = await manager.InsertGenreAsync(newGenre);
            return CreatedAtAction(nameof(GetAll), new {id = insertGenre.Id}, insertGenre);
        }

        [HttpPut]
        public async Task<IActionResult> Put(GenreUpdate GenreUpdate)
        {
            var updateGenre = await manager.UpdateGenreAsync(GenreUpdate);

            if (updateGenre == null)
            {
                return NotFound();
            }

            return Ok(GenreUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteGenreAsync(id);
            return NoContent();
        }
    }
}