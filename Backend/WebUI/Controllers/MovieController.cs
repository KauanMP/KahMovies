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
            return Ok(await manager.InsertMovieAsync(newMovie));
        }
    }
}