using LoyaltyManagement.Tier.Core.Models;

namespace LoyaltyManagement.Tier.Core.Repositories
{
    public interface ITierRepository
    {
        Task<IEnumerable<TierModel>> GetAllAsync();
        Task<TierModel> GetByIdAsync(int id);
        Task CreateAsync(TierModel tier);
        Task UpdateAsync(TierModel tier);
        Task DeleteAsync(int id);
    }
}
