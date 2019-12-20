using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPMovies.Data;
using RPMovies.Models;

namespace RPMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RPMovies.Data.RPMoviesContext _context;

        public IndexModel(RPMovies.Data.RPMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
