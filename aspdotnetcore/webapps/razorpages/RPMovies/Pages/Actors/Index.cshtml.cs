using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPMovies.Data;
using RPMovies.Models;

namespace RPMovies.Pages_Actors
{
    public class IndexModel : PageModel
    {
        private readonly RPMovies.Data.RPMoviesContext _context;

        public IndexModel(RPMovies.Data.RPMoviesContext context)
        {
            _context = context;
        }

        public IList<Actor> Actor { get;set; }

        public async Task OnGetAsync()
        {
            Actor = await _context.Actors.ToListAsync();
        }
    }
}
