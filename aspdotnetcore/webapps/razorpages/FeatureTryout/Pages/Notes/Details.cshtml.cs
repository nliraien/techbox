using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FeatureTryout.Data;
using FeatureTryout.Models;

namespace FeatureTryout.Pages_Notes
{
    public class DetailsModel : PageModel
    {
        private readonly FeatureTryout.Data.NoteContext _context;

        public DetailsModel(FeatureTryout.Data.NoteContext context)
        {
            _context = context;
        }

        public Note Note { get; set; }
        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            // This is just an example of how to return partial view in handler method
            if (id == -1)
            {
                return Partial("_NoteTag");
            }
            //

            Note = await _context.Notes.FirstOrDefaultAsync(m => m.ID == id);

            if (Note == null)
            {
                return NotFound();
            }

            Author = new Author
            {
                Name = "Bill",
                Bio = "New editor on the rise."
            };

            ViewData["Key1"] = "Value1";

            return Page();
        }
    }
}
