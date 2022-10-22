using System;

namespace LeChat.Messaging.Application.Models.ViewModels
{
    public class MessageViewModel
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid SessionId { get; set; }

        public string Text;
        public DateTime DateSeen { get; set; }
        public DateTime DateSent { get; set; }
    }
}
