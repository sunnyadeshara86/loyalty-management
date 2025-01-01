using LoyaltyManagement.Achievement.Core.Models;

namespace LoyaltyManagement.Store.Core.Repositories
{
    public interface IAchievementRepository
    {
        Task<IEnumerable<AchievementModel>> GetAllAsync();
        Task<AchievementModel> GetByIdAsync(int id);
        Task CreateAsync(AchievementModel store);
        Task UpdateAsync(AchievementModel store);
        Task DeleteAsync(int id);
    }

}
