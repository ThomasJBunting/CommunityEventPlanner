
using CommunityEventPlanner.api.Models;

namespace CommunityEventPlanner.api.Controllers
{
    internal interface ICommunityEventService
    {
        Task<CommunityEvent> CreateAsync(CommunityEvent communityEvent);
        Task DeleteAsync(int id);
        Task<IEnumerable<CommunityEvent>> GetAllAsync();
        Task<CommunityEvent> GetByIdAsync(int id);
        Task UpdateAsync(CommunityEvent updateRequest);
    }
}