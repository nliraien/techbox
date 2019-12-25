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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Note = await _context.Notes.FirstOrDefaultAsync(m => m.ID == id);

            if (Note == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
