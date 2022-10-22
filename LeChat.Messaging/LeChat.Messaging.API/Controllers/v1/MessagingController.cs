using LeChat.Messaging.Application.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeChat.Messaging.API.Controllers
{
    public class MessagesController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/user/{userId}/messages")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<MessageViewModel>>> GetUserMessagesAsync([FromQuery] Guid? userId, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
