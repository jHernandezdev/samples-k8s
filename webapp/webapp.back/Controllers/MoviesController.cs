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
        private readonly WebAppContext _context;

        public MoviesController(ILogger<Movie> logger, WebAppContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Movie> peliculas = new List<Movie>
            {
                new Movie { Genre = "Miedito", ID = 1, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "The Ring" },
                new Movie { Genre = "Miedito extremo", ID = 1, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "The Ring 2" },
                new Movie { Genre = "Miedito extremo", ID = 1, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "It" },
                new Movie { Genre = "Risa", ID = 2, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "Top Secret" },
                new Movie { Genre = "Risa", ID = 2, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "Regreso al futuro" }
            };
            return Ok(peliculas);
        }
    }
}
