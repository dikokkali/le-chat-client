using Microsoft.EntityFrameworkCore;
using LeChat.Messaging.Domain.Entities;


namespace LeChat.Messaging.Persistence.Contexts
{
    public class ChatClientMessageDbContext : DbContext
    {
        public DbSet<Message> Message { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ChatSession> ChatSession { get; set; }

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
