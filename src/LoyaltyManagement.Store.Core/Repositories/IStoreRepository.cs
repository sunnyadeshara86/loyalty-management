using LoyaltyManagement.Store.Core.Models;

namespace LoyaltyManagement.Store.Core.Repositories
{
    public interface IStoreRepository
    {
        Task<IEnumerable<StoreModel>> GetAllAsync();
        Task<StoreModel> GetByIdAsync(int id);
        Task CreateAsync(StoreModel store);
        Task UpdateAsync(StoreModel store);
        Task DeleteAsync(int id);
    }

}
