using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeChat.Messaging.Domain.Entities
{
    public class ChatSession
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

       // public virtual ICollection<User> SessionParticipantsList { get; set; }
        public virtual ICollection<Message> SessionMessageList { get; set; }
    }
}
