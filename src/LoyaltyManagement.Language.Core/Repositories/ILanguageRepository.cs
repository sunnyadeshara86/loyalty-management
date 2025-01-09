using LoyaltyManagement.Language.Core.Models;

namespace LoyaltyManagement.Language.Core.Repositories
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<LanguageModel>> GetAllAsync();
        Task<LanguageModel> GetByIdAsync(int id);
        Task CreateAsync(LanguageModel store);
        Task UpdateAsync(LanguageModel store);
        Task DeleteAsync(int id);
    }
}