using System.ComponentModel.DataAnnotations;

namespace MediaManager.Models
{
    public class File
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }
        public string FileType { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationTime { get; set; }
    }
}
