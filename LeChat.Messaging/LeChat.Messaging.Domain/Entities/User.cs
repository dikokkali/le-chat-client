using System;
using System.ComponentModel.DataAnnotations;

namespace LeChat.Messaging.Domain.Entities
{
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Nickname { get; set; }
    }
}