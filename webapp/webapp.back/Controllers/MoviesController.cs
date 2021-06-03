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
            try
            {
                return Ok(_context.Movie.ToList<Movie>());    
            }
            catch (System.Exception ex)
            {
                
                return StatusCode(500, ex.Message);
            }            
        }
    }
}
