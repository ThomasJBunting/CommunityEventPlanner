using CommunityEventPlanner.api.Contracts.Request;
using CommunityEventPlanner.api.Contracts.Response;
using CommunityEventPlanner.api.Models;

namespace CommunityEventPlanner.api.Mapping
{
    public static class CommunityEventsMapping
    {
        public static IEnumerable<CommunityEventResponce> ToCommunityEventsResponse(this IEnumerable<CommunityEvent> communityEvents) =>communityEvents.Select(a => new CommunityEventResponce { Id = a.Id });
        

        public static CommunityEvent ToCommunityEvent(this CommunityEventRequest communityEventRequest) => new CommunityEvent { };
        

        public static CommunityEvent ToCommunityEvent(this UpdateCommunityEventRequest communityEventRequest) => new CommunityEvent { };
    }
}
