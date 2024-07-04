using Microsoft.AspNetCore.Identity;

namespace CommunityEventPlanner.api.Models
{
    public class User : IdentityUser
    {

        public ICollection<CommunityEvent>? CreatedEvents { get; set; }

    }


}