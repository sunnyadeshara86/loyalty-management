using LoyaltyManagement.Store.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Store.Persistence.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IMongoCollection<StoreModel> _storeCollection;

        public StoreRepository(IMongoDatabase database)
        {
            _storeCollection = database.GetCollection<StoreModel>("Stores");
        }

        public async Task<IEnumerable<StoreModel>> GetAllAsync()
        {
            return await _storeCollection.Find(_ => true).ToListAsync();
        }

        public async Task<StoreModel> GetByIdAsync(int id)
        {
            return await _storeCollection.Find(store => store.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(StoreModel store)
        {
            await _storeCollection.InsertOneAsync(store);
        }

        public async Task UpdateAsync(StoreModel store)
        {
            var filter = Builders<StoreModel>.Filter.Eq(s => s.Id, store.Id);
            await _storeCollection.ReplaceOneAsync(filter, store);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<StoreModel>.Filter.Eq(s => s.Id, id);
            await _storeCollection.DeleteOneAsync(filter);
        }
    }
}
