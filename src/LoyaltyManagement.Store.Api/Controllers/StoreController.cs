using LoyaltyManagement.Store.Application.Commands;
using LoyaltyManagement.Store.Application.Queries;
using LoyaltyManagement.Store.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Store.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllStoresQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetStoreByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StoreModel store)
        {
            await _mediator.Send(new CreateStoreCommand(store));
            return CreatedAtAction(nameof(GetById), new { id = store.Id }, store);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] StoreModel store)
        {
            if (id != store.Id)
                return BadRequest();

            await _mediator.Send(new UpdateStoreCommand(store));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteStoreCommand(id));
            return NoContent();
        }
    }
}
