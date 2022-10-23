using AutoMapper;
using LeChat.Messaging.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Mappings
{
    public class MessagingUserProfile : Profile
    {
       public MessagingUserProfile()
        {
            CreateMap<Domain.Entities.User, UserViewModel>();      
        }
    }
}
