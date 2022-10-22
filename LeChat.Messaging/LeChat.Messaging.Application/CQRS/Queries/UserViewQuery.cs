using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Models.Queries
{
    public class UserViewQuery
    {
        public Guid? Id { get; set; }

        public string? FirstName;
        public string? LastName;
        public string? Nickname;
    }
}
