using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MessageStatus
    {
        public Guid MessageStatusId { get; set; }
        public Guid MessageId { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public Message Message { get; set; }
        public User User { get; set; }
    }
}
