using CommunityEventPlanner.api.Contracts.Request;
using CommunityEventPlanner.api.Contracts.Response;
using CommunityEventPlanner.api.Models;

namespace CommunityEventPlanner.api.Mapping
{
    public static class CommunityEventsMapping
    {
        public static IEnumerable<CommunityEventResponse> ToCommunityEventsResponse(this IEnumerable<CommunityEvent> Events) => 
            Events.Select(a => new CommunityEventResponse
        {
            Id = a.Id,
            Name = a.Name,
            Description = a.Description,
            MaximumParticipants = a.MaximumParticipants,
            UserId = a.UserId
         });
        

        public static CommunityEvent ToCommunityEvent(this CommunityEventRequest Request) => 
            new CommunityEvent { Id = Request.Id, 
                Name = Request.Name, 
                Description = Request.Description, 
                MaximumParticipants = Request.MaximumParticipants, 
                UserId = Request.UserId};
        

        public static CommunityEvent ToCommunityEvent(this UpdateCommunityEventRequest Request) => 
            new CommunityEvent { Id = Request.Id, 
                Name = Request.Name, 
                Description = Request.Description, 
                MaximumParticipants = Request.MaximumParticipants, 
                UserId = Request.UserId};
    }
}
