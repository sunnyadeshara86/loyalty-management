using LoyaltyManagement.Member.Core.Models;

namespace LoyaltyManagement.Member.Core.Repositories
{
    public interface IMemberRepository
    {
        Task<IEnumerable<MemberModel>> GetAllAsync();
        Task<MemberModel> GetByIdAsync(int id);
        Task CreateAsync(MemberModel member);
        Task UpdateAsync(MemberModel member);
        Task DeleteAsync(int id);
    }
}
