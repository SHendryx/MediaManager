using System.ComponentModel.DataAnnotations;

namespace MediaManager.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int FileId { get; set; }
    }
}
