using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityEventPlanner.api.Models
{
    public class CommunityEventSubscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string? UserId { get; set; }


        [ForeignKey("UserId")]
        public User? User { get; set; }


        [Required]
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public CommunityEvent? Event { get; set; }
    }


}