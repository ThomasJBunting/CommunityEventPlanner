namespace CommunityEventPlanner.api.Contracts.Request
{
    public class UpdateCommunityEventRequest
    {
        public int Id { get; internal set; }
        public int MaximumParticipants { get; internal set; }
        public string UserId { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
    }
}