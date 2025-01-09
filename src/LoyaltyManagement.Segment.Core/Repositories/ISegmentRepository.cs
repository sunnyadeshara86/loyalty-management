using LoyaltyManagement.Segment.Core.Models;

namespace LoyaltyManagement.Segment.Core.Repositories
{
    public interface ISegmentRepository
    {
        Task<IEnumerable<SegmentModel>> GetAllAsync();
        Task<SegmentModel> GetByIdAsync(int id);
        Task CreateAsync(SegmentModel store);
        Task UpdateAsync(SegmentModel store);
        Task DeleteAsync(int id);
    }
}
