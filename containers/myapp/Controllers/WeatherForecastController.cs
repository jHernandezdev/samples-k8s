using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaludosController : ControllerBase
    {        
        private readonly ILogger<SaludosController> _logger;

        public SaludosController(ILogger<SaludosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hola mundo v2!!");
        }
    }
}
