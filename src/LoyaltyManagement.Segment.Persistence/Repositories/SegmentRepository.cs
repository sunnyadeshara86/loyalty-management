using LoyaltyManagement.Segment.Core.Models;
using LoyaltyManagement.Segment.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Segment.Persistence.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly IMongoCollection<SegmentModel> _segmentCollection;

        public SegmentRepository(IMongoDatabase database)
        {
            _segmentCollection = database.GetCollection<SegmentModel>("Segments");
        }

        public async Task<IEnumerable<SegmentModel>> GetAllAsync()
        {
            return await _segmentCollection.Find(_ => true).ToListAsync();
        }

        public async Task<SegmentModel> GetByIdAsync(int id)
        {
            return await _segmentCollection.Find(segment => segment.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(SegmentModel segment)
        {
            await _segmentCollection.InsertOneAsync(segment);
        }

        public async Task UpdateAsync(SegmentModel segment)
        {
            var filter = Builders<SegmentModel>.Filter.Eq(s => s.Id, segment.Id);
            await _segmentCollection.ReplaceOneAsync(filter, segment);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<SegmentModel>.Filter.Eq(s => s.Id, id);
            await _segmentCollection.DeleteOneAsync(filter);
        }
    }
}
