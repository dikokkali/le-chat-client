using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeChat.Messaging.Domain.Entities
{
    public class Message
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [ForeignKey("Sender")]
        public Guid SenderId { get; set; }

        [ForeignKey("Recipient")]
        public Guid RecipientId { get; set; }

        [ForeignKey("ChatSession")]
        public Guid SessionId { get; set; }

        public string Text { get; set; }
        public DateTime SentTimestamp { get; set; }
        public DateTime? SeenTimestamp { get; set; }

        public virtual User Sender { get; set; }
        public virtual User Recipient { get; set; }
        public virtual ChatSession ChatSession { get; set; }
    }
}
