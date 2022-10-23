using AutoMapper;
using LeChat.Messaging.Application.Models.Commands;
using LeChat.Messaging.Application.Models.CreateModels;
using LeChat.Messaging.Application.Models.Queries;
using LeChat.Messaging.Application.Models.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeChat.Messaging.API.Controllers
{
    public class UsersController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;

        public UsersController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("api/v1/users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUsersAsync([FromQuery] UserViewQuery filter, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(filter, cancellationToken);

            if (result == null)
            {
                Response.StatusCode = StatusCodes.Status204NoContent;
            }
            return Ok(result);            
        }

        [HttpGet]
        [Route("api/v1/users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUserByIdAsync([FromQuery] Guid? id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPost]
        [Route("api/v1/users")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<Guid> CreateNewUser([FromBody] UserCreateModel model, CancellationToken cancellationToken)
        {
            return Guid.Empty;
        }
    }

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
