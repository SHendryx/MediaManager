using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaManager.Data;
using MediaManager.Models;

namespace MediaManager.Pages.Media
{
    public class EditModel : PageModel
    {
        private readonly MediaManager.Data.MediaManagerContext _context;

        public EditModel(MediaManager.Data.MediaManagerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MediaFile MediaFile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mediafile =  await _context.MediaFile.FirstOrDefaultAsync(m => m.Id == id);
            if (mediafile == null)
            {
                return NotFound();
            }
            MediaFile = mediafile;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MediaFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaFileExists(MediaFile.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MediaFileExists(int id)
        {
            return _context.MediaFile.Any(e => e.Id == id);
        }
    }
}
