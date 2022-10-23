using LeChat.Messaging.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Interfaces
{
    public interface IChatClientMessageDbContext
    {
        public DbSet<Message> Message { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ChatSession> ChatSession { get; set; }
    }
}
