using CommunityEventPlanner.api.Controllers;
using CommunityEventPlanner.api.Models;

namespace CommunityEventPlanner.api.Contracts.Request
{
    public class CommunityEventRequest
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public string UserId { get; internal set; }
        public int MaximumParticipants { get; internal set; }
    }
}