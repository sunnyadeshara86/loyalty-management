using LoyaltyManagement.Reward.Core.Models;
using LoyaltyManagement.Reward.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Store.Persistence.Repositories
{
    public class RewardCategoryRepository : IRewardCategoryRepository
    {
        private readonly IMongoCollection<RewardCategoryModel> _rewardCategoryCollection;

        public RewardCategoryRepository(IMongoDatabase database)
        {
            _rewardCategoryCollection = database.GetCollection<RewardCategoryModel>("RewardCategories");
        }

        public async Task<IEnumerable<RewardCategoryModel>> GetAllAsync()
        {
            return await _rewardCategoryCollection.Find(_ => true).ToListAsync();
        }

        public async Task<RewardCategoryModel> GetByIdAsync(int id)
        {
            return await _rewardCategoryCollection.Find(store => store.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(RewardCategoryModel rewardCategory)
        {
            await _rewardCategoryCollection.InsertOneAsync(rewardCategory);
        }

        public async Task UpdateAsync(RewardCategoryModel rewardCategory)
        {
            var filter = Builders<RewardCategoryModel>.Filter.Eq(s => s.Id, rewardCategory.Id);
            await _rewardCategoryCollection.ReplaceOneAsync(filter, rewardCategory);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<RewardCategoryModel>.Filter.Eq(s => s.Id, id);
            await _rewardCategoryCollection.DeleteOneAsync(filter);
        }
    }
}
