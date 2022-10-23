using Microsoft.EntityFrameworkCore;
using LeChat.Messaging.Domain.Entities;
using LeChat.Messaging.Application.Interfaces;

namespace LeChat.Messaging.Persistence.Contexts
{
    public class ChatClientMessageDbContext : DbContext, IChatClientMessageDbContext
    {
        public DbSet<Message> Message { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ChatSession> ChatSession { get; set; }
        public DbSet<Relationship_Friendship> Relationship_Friendship { get; set; }

        public ChatClientMessageDbContext(DbContextOptions<ChatClientMessageDbContext> options) : base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Testing purposes, move conn string in a safe place (use dependency injection or environment vars when deployed)
            var connString = "Data Source=DESKTOP-O975HKH;Database=LeChatMessaging.Dev;Integrated Security=True";
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
