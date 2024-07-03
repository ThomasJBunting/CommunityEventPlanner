using CommunityEventPlanner.api.Contracts.Request;
using CommunityEventPlanner.api.Mapping;
using CommunityEventPlanner.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunityEventPlanner.api.Controllers
{
    [ApiController]
    public class CommunityEventController : Controller()
    {
        private readonly ICommunityEventService _communityEventService;

        [HttpGet("communityEvents")]
        public async Task<IActionResult> Index()
        {
            var communityEvents = await _communityEventService.GetAllAsync();
            var communityEventsResponce = communityEvents.ToCommunityEventsResponse();

            return Ok(communityEventsResponce);

        }


        [HttpGet("communityEvents/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            CommunityEvent? communityEvent = await _communityEventService.GetByIdAsync(id);
            if (communityEvent is null)
            {
                return NotFound();
            }
            return Ok(communityEvent);
        }

        [HttpPost("communityEvents")]
        public async Task<IActionResult> Create([FromBody] CommunityEventRequest request)
        {

            CommunityEvent communityEvent = request.ToCommunityEvent();
            CommunityEvent createdEvent = await _communityEventService.CreateAsync(communityEvent);
            return CreatedAtAction(nameof(GetById), new { id = createdEvent.Id }, createdEvent);
        }

        [HttpPut("communityEvents/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommunityEventRequest Request)
        {
            CommunityEvent existingEvent = await _communityEventService.GetByIdAsync(id);
            if (existingEvent == null)
                return NotFound();

            Request.Id = existingEvent.Id; 

            CommunityEvent UpdateRequest = Request.ToCommunityEvent();

            await _communityEventService.UpdateAsync(UpdateRequest);
            return NoContent();
        }

        [HttpDelete("communityEvents/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            CommunityEvent existingEvent = await _communityEventService.GetByIdAsync(id);
            if (existingEvent == null)
                return NotFound();

            await _communityEventService.DeleteAsync(id);
            return NoContent();
        }
    }
}
