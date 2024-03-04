using Microsoft.EntityFrameworkCore;
using MediaManager.Data;

namespace MediaManager.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MediaManagerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MediaManagerContext>>()))
        {
            if (context == null || context.File == null)
            {
                throw new ArgumentNullException("Null MediaManager");
            }

            // Look for any movies.
            if (context.File.Any())
            {
                return;   // DB has been seeded
            }

            context.File.AddRange(
                new File
                {
                    FilePath = "",
                    FileName = "",
                    FileExtension = "",
                    FileType = "",
                    CreationTime = DateTime.Now,
                }
            );
            context.SaveChanges();
        }
    }
}