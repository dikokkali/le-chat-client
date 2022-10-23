using System;
using System.Collections.Generic;

namespace LeChat.Messaging.Application.Models.ViewModels
{
    public class ChatSessionViewModel
    {
        public Guid Id { get; set; }

        public virtual ICollection<UserViewModel> SessionParticipantsList { get; set; }
        public virtual ICollection<MessageViewModel> SessionMessageList { get; set; }
    }
}
