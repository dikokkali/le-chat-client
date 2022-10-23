using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeChat.Messaging.API.Controllers
{
    public class MessagesController : ControllerBase
    {
        private Mapper _mapper;
        private Mediator _mediator;

        public MessagesController(Mapper mapper, Mediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

       
    }
}
