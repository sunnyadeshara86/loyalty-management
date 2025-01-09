using LoyaltyManagement.Language.Application.Commands;
using LoyaltyManagement.Language.Application.Queries;
using LoyaltyManagement.Language.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyManagement.Language.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _mediator.Send(new GetAllLanguagesQuery());
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var store = await _mediator.Send(new GetLanguageByIdQuery(id));
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LanguageModel language)
        {
            await _mediator.Send(new CreateLanguageCommand(language));
            return CreatedAtAction(nameof(GetById), new { id = language.Id }, language);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] LanguageModel language)
        {
            if (id != language.Id)
                return BadRequest();

            await _mediator.Send(new UpdateLanguageCommand(language));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteLanguageCommand(id));
            return NoContent();
        }
    }
}
