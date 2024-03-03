namespace MediaManager.Models
{
    public class MediaFile
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string MediaType { get; set; } = string.Empty; // Music, Video, etc
        public int LengthSeconds { get; set; }
        public string Container { get; set; } = string.Empty;
        public string Codec { get; set; } = string.Empty;
        public string? AudioFormat { get; set; }
        public string? VideoFormat { get; set; }
    }
}
