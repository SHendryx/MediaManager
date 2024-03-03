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
    public class IndexModel : PageModel
    {
        private readonly MediaManager.Data.MediaManagerContext _context;

        public IndexModel(MediaManager.Data.MediaManagerContext context)
        {
            _context = context;
        }

        public IList<MediaFile> MediaFile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MediaFile = await _context.MediaFile.ToListAsync();
        }
    }
}
