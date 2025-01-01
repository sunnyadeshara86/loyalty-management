using LoyaltyManagement.Tier.Core.Models;
using LoyaltyManagement.Tier.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Tier.Persistence.Repositories
{
    public class TierRepository : ITierRepository
    {
        private readonly IMongoCollection<TierModel> _tierCollection;

        public TierRepository(IMongoDatabase database)
        {
            _tierCollection = database.GetCollection<TierModel>("Tiers");
        }

        public async Task<IEnumerable<TierModel>> GetAllAsync()
        {
            return await _tierCollection.Find(_ => true).ToListAsync();
        }

        public async Task<TierModel> GetByIdAsync(int id)
        {
            return await _tierCollection.Find(tier => tier.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(TierModel tier)
        {
            await _tierCollection.InsertOneAsync(tier);
        }

        public async Task UpdateAsync(TierModel tier)
        {
            var filter = Builders<TierModel>.Filter.Eq(s => s.Id, tier.Id);
            await _tierCollection.ReplaceOneAsync(filter, tier);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<TierModel>.Filter.Eq(s => s.Id, id);
            await _tierCollection.DeleteOneAsync(filter);
        }
    }
}
