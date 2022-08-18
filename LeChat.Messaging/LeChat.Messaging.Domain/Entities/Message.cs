using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Domain.Entities
{
    public class Message
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [ForeignKey("UserProfile")]
        public Guid UserProfileId { get; set; }

        [ForeignKey("ChatSession")]
        public Guid ChatSessionId { get; set; }

        public string Text { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime? DateSeen { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        public virtual ChatSession ChatSession { get; set; }
    }
}
