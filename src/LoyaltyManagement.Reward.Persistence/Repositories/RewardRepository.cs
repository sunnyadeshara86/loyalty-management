using LoyaltyManagement.Reward.Core.Models;
using LoyaltyManagement.Reward.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Store.Persistence.Repositories
{
    public class RewardRepository : IRewardRepository
    {
        private readonly IMongoCollection<RewardModel> _rewardCollection;

        public RewardRepository(IMongoDatabase database)
        {
            _rewardCollection = database.GetCollection<RewardModel>("Rewards");
        }

        public async Task<IEnumerable<RewardModel>> GetAllAsync()
        {
            return await _rewardCollection.Find(_ => true).ToListAsync();
        }

        public async Task<RewardModel> GetByIdAsync(int id)
        {
            return await _rewardCollection.Find(store => store.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(RewardModel reward)
        {
            await _rewardCollection.InsertOneAsync(reward);
        }

        public async Task UpdateAsync(RewardModel reward)
        {
            var filter = Builders<RewardModel>.Filter.Eq(s => s.Id, reward.Id);
            await _rewardCollection.ReplaceOneAsync(filter, reward);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<RewardModel>.Filter.Eq(s => s.Id, id);
            await _rewardCollection.DeleteOneAsync(filter);
        }
    }
}
