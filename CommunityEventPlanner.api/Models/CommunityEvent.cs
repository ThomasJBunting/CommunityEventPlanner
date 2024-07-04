using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityEventPlanner.api.Models
{

    public class CommunityEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(500)]
        public string? Description { get; set; }
        public int MaximumParticipants { get; set; }


        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public User? CreateByUser { get; set; }

    }


}