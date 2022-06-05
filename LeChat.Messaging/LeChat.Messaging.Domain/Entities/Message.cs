using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateSeen { get; set; }
    }
}
