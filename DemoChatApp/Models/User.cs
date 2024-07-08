using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : IdentityUser
    {
        public string FirstName {  get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set;}
        public DateTime? LastLogin {  get; set; }
        public string Avatar {  get; set; }
        public string StatusMessage {  get; set; }

        // Navigation properties
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<ChatRoomMember> ChatRoomMembers { get; set; } = new List<ChatRoomMember>();
        public ICollection<Friendship> Friendships { get; set; } = new List<Friendship>();
        public ICollection<MessageStatus> MessageStatuses { get; set; } = new List<MessageStatus>();

    }
}
