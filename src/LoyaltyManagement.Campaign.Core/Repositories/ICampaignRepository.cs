using LoyaltyManagement.Campaign.Core.Models;

namespace LoyaltyManagement.Campaign.Core.Repositories
{
    public interface ICampaignRepository
    {
        Task<IEnumerable<CampaignModel>> GetAllAsync();
        Task<CampaignModel> GetByIdAsync(int id);
        Task CreateAsync(CampaignModel member);
        Task UpdateAsync(CampaignModel member);
        Task DeleteAsync(int id);
    }
}
