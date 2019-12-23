using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RPMovies.Data;
using RPMovies.Models;

namespace RPMovies.Pages_Actors
{
    public class CreateModel : PageModel
    {
        private readonly RPMovies.Data.RPMoviesContext _context;

        public CreateModel(RPMovies.Data.RPMoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Actor Actor { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Actors.Add(Actor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
