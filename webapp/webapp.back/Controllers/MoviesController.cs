using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp.back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<Movie> _logger;

        public MoviesController(ILogger<Movie> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Movie> peliculas = new List<Movie>
            {
                new Movie { Genre = "Miedo", ID = 1, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "The Ring" },
                new Movie { Genre = "Risa", ID = 2, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "Top Secret" }
            };
            return Ok(peliculas);
        }
    }
}
