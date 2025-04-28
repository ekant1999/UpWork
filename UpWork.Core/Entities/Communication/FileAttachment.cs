using UpWork.Core.Entities.Communication;

namespace UpWork.Core.Entities.Communication
{
    public class FileAttachment
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public DateTime UploadedAt { get; set; }

        // Navigation properties
        public virtual Message Message { get; set; }
    }
}
