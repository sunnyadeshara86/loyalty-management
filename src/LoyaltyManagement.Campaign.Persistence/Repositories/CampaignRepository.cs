using LoyaltyManagement.Campaign.Core.Models;
using LoyaltyManagement.Campaign.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Campaign.Persistence.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly IMongoCollection<CampaignModel> _campaignRepository;

        public CampaignRepository(IMongoDatabase database)
        {
            _campaignRepository = database.GetCollection<CampaignModel>("Campaigns");
        }

        public async Task<IEnumerable<CampaignModel>> GetAllAsync()
        {
            return await _campaignRepository.Find(_ => true).ToListAsync();
        }

        public async Task<CampaignModel> GetByIdAsync(int id)
        {
            return await _campaignRepository.Find(store => store.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(CampaignModel campaign)
        {
            await _campaignRepository.InsertOneAsync(campaign);
        }

        public async Task UpdateAsync(CampaignModel campaign)
        {
            var filter = Builders<CampaignModel>.Filter.Eq(s => s.Id, campaign.Id);
            await _campaignRepository.ReplaceOneAsync(filter, campaign);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<CampaignModel>.Filter.Eq(s => s.Id, id);
            await _campaignRepository.DeleteOneAsync(filter);
        }
    }
}