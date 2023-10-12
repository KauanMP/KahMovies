using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository repository;

        public MovieController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies(Movie movie)
        {
            return Ok(await repository.GetAllMoviesAsync(movie));
        }
    }
}