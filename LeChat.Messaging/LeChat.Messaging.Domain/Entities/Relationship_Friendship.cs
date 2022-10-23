using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Domain.Entities
{
    public class Relationship_Friendship
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [ForeignKey("SourceUser")]
        public Guid SourceUserId { get; set; }

        [ForeignKey("TargetUser")]
        public Guid TargetUserId { get; set; }

        public DateTime AcceptedTimestamp { get; set; }   
        
        public virtual User SourceUser { get; set; }
        public virtual User TargetUser { get; set; }
    }
}
