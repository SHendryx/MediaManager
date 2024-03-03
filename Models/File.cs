using System.ComponentModel.DataAnnotations;

namespace MediaManager.Models
{
    public class File
    {
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        [DataType(DataType.DateTime)]
        public DateTime CreationTime { get; set; }
    }
}
