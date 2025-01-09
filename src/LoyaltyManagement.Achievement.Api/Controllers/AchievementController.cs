using LoyaltyManagement.Achievement.Application.Commands;
using LoyaltyManagement.Achievement.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static LoyaltyManagement.Achievement.Application.Queries.QueryRecords;

namespace LoyaltyManagement.Achievement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AchievementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllAchievementsQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetAchievementByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AchievementModel achievement)
        {
            await _mediator.Send(new CreateAchievementCommand(achievement));
            return CreatedAtAction(nameof(GetById), new { id = achievement.Id }, achievement);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AchievementModel achievement)
        {
            if (id != achievement.Id)
                return BadRequest();

            await _mediator.Send(new UpdateAchievementCommand(achievement));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteAchievementCommand(id));
            return NoContent();
        }
    }
}
