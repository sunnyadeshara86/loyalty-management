using LoyaltyManagement.Channel.Core.Models;
using LoyaltyManagement.Channel.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Channel.Persistence.Repositories
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly IMongoCollection<ChannelModel> _channelCollection;

        public ChannelRepository(IMongoDatabase database)
        {
            _channelCollection = database.GetCollection<ChannelModel>("Channels");
        }

        public async Task<IEnumerable<ChannelModel>> GetAllAsync()
        {
            return await _channelCollection.Find(_ => true).ToListAsync();
        }

        public async Task<ChannelModel> GetByIdAsync(int id)
        {
            return await _channelCollection.Find(channel => channel.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(ChannelModel channel)
        {
            await _channelCollection.InsertOneAsync(channel);
        }

        public async Task UpdateAsync(ChannelModel channel)
        {
            var filter = Builders<ChannelModel>.Filter.Eq(s => s.Id, channel.Id);
            await _channelCollection.ReplaceOneAsync(filter, channel);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<ChannelModel>.Filter.Eq(s => s.Id, id);
            await _channelCollection.DeleteOneAsync(filter);
        }
    }
}
