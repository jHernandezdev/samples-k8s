using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.front.Models;

namespace webapp.front.Pages.Movies
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Peliculas;

        public void OnGet()
        {
            Peliculas = new List<Movie>
            {
                new Movie { Genre = "Miedo", ID = 1, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "The Ring" },
                new Movie { Genre = "Risa", ID = 2, Price = 2.10m, ReleaseDate = DateTime.Now, Title = "Top Secret" }
            };
        }
    }
}