using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ChatRoom
    {
        public Guid ChatRoomId { get; set; }
        public string ChatRoomName { get; set; }
        public bool IsGroup { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public ICollection<ChatRoomMember> ChatRoomMembers { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
