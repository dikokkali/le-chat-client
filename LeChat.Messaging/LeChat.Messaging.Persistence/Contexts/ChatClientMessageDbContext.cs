using Microsoft.EntityFrameworkCore;

using LeChat.Messaging.Domain.Entities;


namespace LeChat.Messaging.Persistence.Contexts
{
    public class ChatClientMessageDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}
