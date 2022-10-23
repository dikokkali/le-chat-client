﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Models.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Nickname { get; set; }
    }
}
