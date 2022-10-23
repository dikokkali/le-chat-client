using System;

namespace LeChat.Messaging.Application.Models.ViewModels
{
    public class MessageViewModel
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public Guid SessionId { get; set; }

        public string Text;
        public DateTime SentTimestamp { get; set; }
        public DateTime SeenTimestamp { get; set; }

        public virtual UserViewModel Sender { get; set; }
        public virtual UserViewModel Recipient { get; set; }
        public virtual ChatSessionViewModel ChatSession { get; set; }
    }
}
