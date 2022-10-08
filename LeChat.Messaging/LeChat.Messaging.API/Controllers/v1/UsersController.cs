using LeChat.Messaging.Application.Models.Queries;
using LeChat.Messaging.Application.Models.ViewModels;
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
       [HttpGet]
       [Route("api/v1/users")]
       [ProducesResponseType(StatusCodes.Status200OK)]
       [ProducesResponseType(StatusCodes.Status204NoContent)]
       public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUsersAsync([FromQuery] UserViewQuery filter, CancellationToken cancellationToken)
       {
            return Ok();
       }

        [HttpGet]
        [Route("api/v1/users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUserByIdAsync([FromQuery] Guid? id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
