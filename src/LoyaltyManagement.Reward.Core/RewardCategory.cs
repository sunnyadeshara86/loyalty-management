namespace LoyaltyManagement.Reward.Core
{
    public class RewardCategory
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public List<RewardCategoryReward> Rewards { get; set; } = new();
        public List<RewardCategoryTranslation> RewardCategoryTranslations { get; set; } = new();
    }
}
