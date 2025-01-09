using LoyaltyManagement.Language.Core.Models;
using LoyaltyManagement.Language.Core.Repositories;
using MongoDB.Driver;

namespace LoyaltyManagement.Language.Persistence.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly IMongoCollection<LanguageModel> _languageCollection;

        public LanguageRepository(IMongoDatabase database)
        {
            _languageCollection = database.GetCollection<LanguageModel>("Languages");
        }

        public async Task<IEnumerable<LanguageModel>> GetAllAsync()
        {
            return await _languageCollection.Find(_ => true).ToListAsync();
        }

        public async Task<LanguageModel> GetByIdAsync(int id)
        {
            return await _languageCollection.Find(language => language.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(LanguageModel language)
        {
            await _languageCollection.InsertOneAsync(language);
        }

        public async Task UpdateAsync(LanguageModel language)
        {
            var filter = Builders<LanguageModel>.Filter.Eq(s => s.Id, language.Id);
            await _languageCollection.ReplaceOneAsync(filter, language);
        }

        public async Task DeleteAsync(int id)
        {
            var filter = Builders<LanguageModel>.Filter.Eq(s => s.Id, id);
            await _languageCollection.DeleteOneAsync(filter);
        }
    }
}
