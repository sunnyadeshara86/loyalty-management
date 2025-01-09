using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Application.Queries;
using LoyaltyManagement.Reward.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Reward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RewardCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Rewards = await _mediator.Send(new GetAllRewardCategoriesQuery());
            return Ok(Rewards);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Reward = await _mediator.Send(new GetRewardCategoryByIdQuery(id));
            if (Reward == null)
                return NotFound();
            return Ok(Reward);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RewardCategoryModel rewardCategory)
        {
            await _mediator.Send(new CreateRewardCategoryCommand(rewardCategory));
            return CreatedAtAction(nameof(GetById), new { id = rewardCategory.Id }, rewardCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] RewardCategoryModel rewardCategory)
        {
            if (id != rewardCategory.Id)
                return BadRequest();

            await _mediator.Send(new UpdateRewardCategoryCommand(rewardCategory));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRewardCategoryCommand(id));
            return NoContent();
        }
    }
}
