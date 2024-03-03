using System.ComponentModel.DataAnnotations;

namespace MediaManager.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string MediaType { get; set; } = string.Empty; // Music, Video, etc
        public TimeSpan Length { get; set; }
        public string Container { get; set; } = string.Empty;
        public string Codec { get; set; } = string.Empty;
        public string? AudioFormat { get; set; }
        public string? VideoFormat { get; set; }
    }
}
