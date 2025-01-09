using LoyaltyManagement.Campaign.Application.Commands;
using LoyaltyManagement.Campaign.Application.Queries;
using LoyaltyManagement.Campaign.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Campaign.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CampaignController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var campaigns = await _mediator.Send(new GetAllCampaignsQuery());
            return Ok(campaigns);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetCampaignByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CampaignModel campaign)
        {
            await _mediator.Send(new CreateCampaignCommand(campaign));
            return CreatedAtAction(nameof(GetById), new { id = campaign.Id }, campaign);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CampaignModel campaign)
        {
            if (id != campaign.Id)
                return BadRequest();

            await _mediator.Send(new UpdateCampaignCommand(campaign));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCampaignCommand(id));
            return NoContent();
        }
    }
}
