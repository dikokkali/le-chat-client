using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Models.Commands
{
    public class UserCreateCommand
    {
        public string FirstName;
        public string LastName;
        public string? Nickname;
    }
}
