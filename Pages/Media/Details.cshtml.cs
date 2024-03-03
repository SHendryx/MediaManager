using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediaManager.Data;
using MediaManager.Models;

namespace MediaManager.Pages.Media
{
    public class DetailsModel : PageModel
    {
        private readonly MediaManager.Data.MediaManagerContext _context;

        public DetailsModel(MediaManager.Data.MediaManagerContext context)
        {
            _context = context;
        }

        public MediaFile MediaFile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mediafile = await _context.MediaFile.FirstOrDefaultAsync(m => m.Id == id);
            if (mediafile == null)
            {
                return NotFound();
            }
            else
            {
                MediaFile = mediafile;
            }
            return Page();
        }
    }
}
