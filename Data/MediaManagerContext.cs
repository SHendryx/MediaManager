using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediaManager.Models;

namespace MediaManager.Data
{
    public class MediaManagerContext : DbContext
    {
        public MediaManagerContext (DbContextOptions<MediaManagerContext> options)
            : base(options)
        {
        }

        public DbSet<MediaManager.Models.MediaFile> MediaFile { get; set; } = default!;
        public DbSet<MediaManager.Models.File> File { get; set; } = default!;
    }
}
