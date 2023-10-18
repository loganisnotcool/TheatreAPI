using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return MockDB.Movies;
        }
        [HttpPost]
        
        public IActionResult CreateMovie([FromBody] Movie movie)
        {
            movie.Id = MockDB.Movies.Max(m => m.Id) + 1;
            MockDB.Movies.Add(movie);

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }
    }
}
