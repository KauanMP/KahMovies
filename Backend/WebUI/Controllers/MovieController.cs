using Domain.Entities;
using Domain.Interfaces;
using Domain.ModelViews.Movie;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieManager manager;

        public MovieController(IMovieManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await manager.GetAllMoviesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await manager.GetMovieByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewMovie newMovie)
        {
            var insertMovie = await manager.InsertMovieAsync(newMovie);
            return CreatedAtAction(nameof(GetAll), new { id = insertMovie.Id}, insertMovie);
        }

        [HttpPut]
        public async Task<IActionResult> Put(MovieUpdate movieUpdate)
        {
            var updatedMovie = await manager.UpdateMovieAsync(movieUpdate);

            if (updatedMovie == null)
            {
                return NotFound();
            }

            return Ok(updatedMovie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await manager.DeleteMovieAsync(id);
            return NoContent();
        }
    }
}