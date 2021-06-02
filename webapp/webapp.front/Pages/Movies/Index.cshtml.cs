using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.front.Models;
using Microsoft.Extensions.Logging;

namespace webapp.front.Pages.Movies
{
    public class MoviesModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<MoviesModel> _logger;

        public MoviesModel(IHttpClientFactory clientFactory, ILogger<MoviesModel> logger)
        {
            _clientFactory = clientFactory;
            _logger = logger;
        }

        public List<Movie> Peliculas;
        
        public async Task OnGet()
        {
            Peliculas = new List<Movie>();
            var client = _clientFactory.CreateClient("webapp.back");
           
           _logger.LogInformation(client.BaseAddress.ToString());            
            var resultado = await client.GetAsync("/Movies");
            if (resultado.IsSuccessStatusCode)
            {
                string response = await resultado.Content.ReadAsStringAsync();
                Peliculas.AddRange(Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Movie>>(response));
            }            
        }
    }
}