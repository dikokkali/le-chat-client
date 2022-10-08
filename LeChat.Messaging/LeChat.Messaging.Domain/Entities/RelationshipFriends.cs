using System;
using System.ComponentModel.DataAnnotations;

namespace LeChat.Messaging.Domain.Entities
{
    public class RelationshipFriends
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public Guid RequesterId { get; set; }
        public Guid ReceiverId { get; set; }
    }
}
