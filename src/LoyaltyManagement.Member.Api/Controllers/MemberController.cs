using LoyaltyManagement.Member.Application.Commands;
using LoyaltyManagement.Member.Application.Queries;
using LoyaltyManagement.Member.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Member.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllMembersQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetMemberByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MemberModel member)
        {
            await _mediator.Send(new CreateMemberCommand(member));
            return CreatedAtAction(nameof(GetById), new { id = member.Id }, member);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MemberModel member)
        {
            if (id != member.Id)
                return BadRequest();

            await _mediator.Send(new UpdateMemberCommand(member));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteMemberCommand(id));
            return NoContent();
        }
    }
}
