using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ChatRoomMember
    {
        public Guid ChatRoomMemberId { get; set; }
        public Guid ChatRoomId { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.Now;
        public string Role { get; set; }

        // Navigation properties
        public ChatRoom ChatRoom { get; set; }
        public User User { get; set; }
    }
}
