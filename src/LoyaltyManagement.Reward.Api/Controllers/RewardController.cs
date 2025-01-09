using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Application.Queries;
using LoyaltyManagement.Reward.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Reward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RewardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var rewards = await _mediator.Send(new GetAllRewardsQuery());
            return Ok(rewards);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var reward = await _mediator.Send(new GetRewardByIdQuery(id));
            if (reward == null)
                return NotFound();
            return Ok(reward);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RewardModel reward)
        {
            await _mediator.Send(new CreateRewardCommand(reward));
            return CreatedAtAction(nameof(GetById), new { id = reward.Id }, reward);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] RewardModel reward)
        {
            if (id != reward.Id)
                return BadRequest();

            await _mediator.Send(new UpdateRewardCommand(reward));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRewardCommand(id));
            return NoContent();
        }
    }
}
