using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MediaManager.Data;
using MediaManager.Models;

namespace MediaManager.Pages.Media
{
    public class CreateModel : PageModel
    {
        private readonly MediaManager.Data.MediaManagerContext _context;

        public CreateModel(MediaManager.Data.MediaManagerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MediaFile MediaFile { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MediaFile.Add(MediaFile);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
