using LoyaltyManagement.Achievement.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Achievement.Persistence.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly IMongoCollection<AchievementModel> _achievementCollection;

        public AchievementRepository(IMongoDatabase database)
        {
            _achievementCollection = database.GetCollection<AchievementModel>("Achievements");
        }

        public async Task<IEnumerable<AchievementModel>> GetAllAsync()
        {
            return await _achievementCollection.Find(_ => true).ToListAsync();
        }

        public async Task<AchievementModel> GetByIdAsync(int id)
        {
            return await _achievementCollection.Find(achievement => achievement.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(AchievementModel achievement)
        {
            await _achievementCollection.InsertOneAsync(achievement);
        }

        public async Task UpdateAsync(AchievementModel achievement)
        {
            var filter = Builders<AchievementModel>.Filter.Eq(s => s.Id, achievement.Id);
            await _achievementCollection.ReplaceOneAsync(filter, achievement);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<AchievementModel>.Filter.Eq(s => s.Id, id);
            await _achievementCollection.DeleteOneAsync(filter);
        }
    }

}
