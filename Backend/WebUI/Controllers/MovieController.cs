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
        public async Task<IActionResult> GetAllMovies()
        {
            return Ok(await manager.GetAllMoviesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            return Ok(await manager.GetMovieByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertMovie(NewMovie newMovie)
        {
            var insertMovie = await manager.InsertMovieAsync(newMovie);
            return CreatedAtAction(nameof(GetAllMovies), new { id = insertMovie.Id}, insertMovie);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie(MovieUpdate movieUpdate)
        {
            var updatedMovie = await manager.UpdateMovieAsync(movieUpdate);

            if (updatedMovie == null)
            {
                return NotFound();
            }

            return Ok(updatedMovie);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await manager.DeleteMovieAsync(id);
            return NoContent();
        }
    }
}