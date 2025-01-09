using LoyaltyManagement.Reward.Core.Models;

namespace LoyaltyManagement.Reward.Core.Repositories
{
    public interface IRewardRepository
    {
        Task<IEnumerable<RewardModel>> GetAllAsync();
        Task<RewardModel> GetByIdAsync(int id);
        Task CreateAsync(RewardModel store);
        Task UpdateAsync(RewardModel store);
        Task DeleteAsync(int id);
    }
}
