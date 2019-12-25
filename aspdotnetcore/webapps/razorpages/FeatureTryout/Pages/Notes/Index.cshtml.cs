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
    public class IndexModel : PageModel
    {
        private readonly FeatureTryout.Data.NoteContext _context;

        public IndexModel(FeatureTryout.Data.NoteContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; }

        public async Task OnGetAsync()
        {
            Note = await _context.Notes.ToListAsync();
        }
    }
}
