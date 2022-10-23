using LeChat.Messaging.Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;

namespace LeChat.Messaging.Application.Models.Queries
{
    public class UserViewQuery: IRequest<IEnumerable<UserViewModel>>
    {
        public Guid? Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nickname { get; set; }
    }
}
