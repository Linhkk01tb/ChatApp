using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Attachment
    {
        public Guid AttachmentId { get; set; }
        public Guid MessageId { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public Message Message { get; set; }
    }
}
