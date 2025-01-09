using LoyaltyManagement.Reward.Core.Models;

namespace LoyaltyManagement.Reward.Core.Repositories
{
    public interface IRewardCategoryRepository
    {
        Task<IEnumerable<RewardCategoryModel>> GetAllAsync();
        Task<RewardCategoryModel> GetByIdAsync(int id);
        Task CreateAsync(RewardCategoryModel store);
        Task UpdateAsync(RewardCategoryModel store);
        Task DeleteAsync(int id);
    }
}
