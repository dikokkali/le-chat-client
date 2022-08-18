using Microsoft.EntityFrameworkCore;

using LeChat.Messaging.Domain.Entities;


namespace LeChat.Messaging.Persistence.Contexts
{
    public class ChatClientMessageDbContext : DbContext
    {
        public DbSet<Message> Message { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<ChatSession> ChatSession { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Testing purposes, move conn string in a safe place (use dependency injection or environment vars when deployed)
            var connString = "User ID=ebtghxkrsexylv;Password=c768c30f63b8263f65fc91fbe28dbe35f67548f040e1b41390bd3595b2fbc680;Host=ec2-99-80-170-190.eu-west-1.compute.amazonaws.com;Port=5432;Database=d5glm4iok92beq;Pooling=true;SSL Mode=Require;TrustServerCertificate=True;";
            optionsBuilder.UseNpgsql(connString);
        }

    }
}
