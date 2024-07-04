using System.ComponentModel.DataAnnotations;

namespace CommunityEventPlanner.api.Contracts.Response
{
    public class CommunityEventResponse
    {
        public int Id { get; internal set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        public string? Description { get; set; }
        public int MaximumParticipants { get; set; }

        public string? UserId { get; set; }
    }
}