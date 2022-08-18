using System;
using System.ComponentModel.DataAnnotations;

namespace LeChat.Messaging.Domain.Entities
{
    public class UserProfile
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public string FirstName;
        public string LastName;
        public string? Nickname;
    }
}
