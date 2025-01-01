using LoyaltyManagement.Member.Core.Models;
using LoyaltyManagement.Member.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Member.Persistence.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly IMongoCollection<MemberModel> _memberRepository;

        public MemberRepository(IMongoDatabase database)
        {
            _memberRepository = database.GetCollection<MemberModel>("Members");
        }

        public async Task<IEnumerable<MemberModel>> GetAllAsync()
        {
            return await _memberRepository.Find(_ => true).ToListAsync();
        }

        public async Task<MemberModel> GetByIdAsync(int id)
        {
            return await _memberRepository.Find(store => store.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(MemberModel member)
        {
            await _memberRepository.InsertOneAsync(member);
        }

        public async Task UpdateAsync(MemberModel member)
        {
            var filter = Builders<MemberModel>.Filter.Eq(s => s.Id, member.Id);
            await _memberRepository.ReplaceOneAsync(filter, member);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<MemberModel>.Filter.Eq(s => s.Id, id);
            await _memberRepository.DeleteOneAsync(filter);
        }
    }
}
