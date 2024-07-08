using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ChatAppDbContext : IdentityDbContext<User>
    {
        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options) { }

        #region DbSet

        public DbSet<Message> Messages;

        public DbSet<ChatRoom> ChatRooms;

        public DbSet<ChatRoomMember> ChatRoomsMembers;

        public DbSet<Friendship> Friendships;

        public DbSet<Attachment> Attachments;

        public DbSet<MessageStatus> MessageStatuses;

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message>(ent =>
            {
                ent.ToTable("Messages");
                ent.HasKey(m => m.MessageId);
                ent.HasOne(m => m.Sender).WithMany(m => m.SentMessages).HasForeignKey(m => m.SenderId).HasConstraintName("FK_USER_MESSGAE").OnDelete(DeleteBehavior.Restrict);
                ent.HasOne(m => m.ChatRoom).WithMany(m => m.Messages).HasForeignKey(m => m.ChatRoomId).HasConstraintName("FK_CHATROOM_MESSGAE").OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Friendship>(ent =>
            {
                ent.ToTable("Friendships");
                ent.HasKey(f => f.FriendshipId);
                ent.HasOne(f => f.User1).WithMany(f => f.Friendships).HasForeignKey(f => f.UserId1).HasConstraintName("FK_FRIENDSHIP_USER1").OnDelete(DeleteBehavior.Restrict);
                ent.HasOne(f => f.User2).WithMany().HasForeignKey(f => f.UserId2).HasConstraintName("FK_FRIENDSHIP_USER2").OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<>
        }
    }
}
