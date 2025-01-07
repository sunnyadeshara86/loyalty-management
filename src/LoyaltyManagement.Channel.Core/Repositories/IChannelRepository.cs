using LoyaltyManagement.Channel.Core.Models;

namespace LoyaltyManagement.Channel.Core.Repositories
{
    public interface IChannelRepository
    {
        Task<IEnumerable<ChannelModel>> GetAllAsync();
        Task<ChannelModel> GetByIdAsync(int id);
        Task CreateAsync(ChannelModel store);
        Task UpdateAsync(ChannelModel store);
        Task DeleteAsync(int id);
    }
}
