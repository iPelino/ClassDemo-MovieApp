using Microsoft.AspNetCore.Mvc;
using RazorPagesMovieApp.Models;

namespace MovieAPI.Controllers;

[Route("api/[controller]")] // api/movies
[ApiController]
public class TestMoviesController : ControllerBase
{
    [HttpGet] // api/movies
    public ActionResult<Movie> GetMovies()
    {
        return Ok("All movies");
    }
    
    [HttpGet("{id}")] // api/movies/1
    public ActionResult<Movie> GetMovie(int id)
    {
        return Ok($"Movie with id {id}");
    }
}
