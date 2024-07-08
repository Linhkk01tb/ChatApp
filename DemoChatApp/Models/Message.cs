using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Message
    {
        public Guid MessageId { get; set; }

        public Guid SenderId { get; set; }

        public Guid? ChatRoomId { get; set; }

        public string Content {  get; set; }

        public DateTime SentAt { get; set; }

        public string MessageType {  get; set; }

        public Guid ParentMessageId {  get; set; }

        // Navigation properties
        public User Sender { get; set; }
        public ChatRoom ChatRoom { get; set; }
        public Message ParentMessage { get; set; }
        public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
        public ICollection<MessageStatus> MessageStatuses { get; set; } = new List<MessageStatus>();
    }
}
