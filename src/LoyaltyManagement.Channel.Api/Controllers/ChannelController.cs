using LoyaltyManagement.Channel.Application.Commands;
using LoyaltyManagement.Channel.Application.Queries;
using LoyaltyManagement.Channel.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Channel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChannelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllChannelsQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetChannelByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ChannelModel channel)
        {
            await _mediator.Send(new CreateChannelCommand(channel));
            return CreatedAtAction(nameof(GetById), new { id = channel.Id }, channel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ChannelModel channel)
        {
            if (id != channel.Id)
                return BadRequest();

            await _mediator.Send(new UpdateChannelCommand(channel));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteChannelCommand(id));
            return NoContent();
        }
    }
}
