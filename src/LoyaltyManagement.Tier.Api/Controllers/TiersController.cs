using LoyaltyManagement.Store.Application.Commands;
using LoyaltyManagement.Tier.Application.Queries;
using LoyaltyManagement.Tier.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Tier.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TiersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllTiersQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetTierByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TierModel tier)
        {
            await _mediator.Send(new CreateTierCommand(tier));
            return CreatedAtAction(nameof(GetById), new { id = tier.Id }, tier);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TierModel tier)
        {
            if (id != tier.Id)
                return BadRequest();

            await _mediator.Send(new UpdateTierCommand(tier));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteTierCommand(id));
            return NoContent();
        }
    }
}
